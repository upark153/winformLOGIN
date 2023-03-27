using System;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApp2
{
    class Client
    {
        public class ObjectState
        {
            public Socket wSocket = null; // 소켓
            public const int _buffsize = 1024; // 수신 버퍼 크기
            public byte[] Buffer = new byte[_buffsize]; // 버퍼 수신
            public StringBuilder sb = new StringBuilder(); // 수신된 데이터 문자열
        }
        public class AsyncSocketClient
        {
            private const int Port = 9001; // 포트 번호
            private readonly static IPAddress ipAddr = IPAddress.Parse("10.10.21.105");
            // 1.클래스 생성, 2.객체 생성. 3. 객체를 인스턴스화 ( 객체를 메모리에 할당 )
            private static ManualResetEvent connectCompleted = new ManualResetEvent(false);
            private static ManualResetEvent sendCompleted = new ManualResetEvent(false);
            private static ManualResetEvent receiveCompleted = new ManualResetEvent(false);
            private static string response = String.Empty;

            public static void StartClient()
            {
                try
                {
                    //IPHostEntry ipHost = Dns.GetHostEntry(ipaddr);
                    //IPEndPoint remoteEndPoint = new IPEndPoint(ipaddr, Port); // 연결

                    // 소켓 객체 생성 및 인스턴스 초기화
                    Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    //client.BeginConnect(remoteEndPoint, new AsyncCallback(ConnectionCallback), client);
                    connectCompleted.WaitOne();

                    //Send(client, data);
                    sendCompleted.WaitOne();

                    Receive(client);
                    receiveCompleted.WaitOne();

                    Console.WriteLine($"Response received {response}");

                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            private static void Receive(Socket client)
            {
                try
                {
                    ObjectState state = new ObjectState();
                    state.wSocket = client;
                    client.BeginReceive(state.Buffer, 0, ObjectState._buffsize,0,new AsyncCallback(ReceiveCallback), state); // 콜백을 받은 이후 상태
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            private static void ReceiveCallback(IAsyncResult ar)
            {
                // 비동기 콜백 여기서는 어떤 작업을 하게 될까?
                try
                {
                    ObjectState state = (ObjectState)ar.AsyncState; // 객체 상태를 전달.
                    Socket client = state.wSocket;
                    int byteRead = client.EndReceive(ar);
                    if (byteRead > 0)
                    {
                        state.sb.Append(Encoding.ASCII.GetString(state.Buffer, 0, byteRead));
                        client.BeginReceive(state.Buffer, 0, ObjectState._buffsize, 0, new AsyncCallback(ReceiveCallback), state);
                    }
                    else // 모든 데이터를 받을 경우, 응답에 알린다.
                    {
                        if (state.sb.Length > 1)
                        {
                            response = state.sb.ToString();
                        }
                        receiveCompleted.Set(); // 모든 바이트를 받았음을 알리는 신호
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            private static void Send(Socket client, string data)
            {
                byte[] byteData = Encoding.ASCII.GetBytes(data);
                client.BeginSend(byteData,0,byteData.Length,0, new AsyncCallback(SendCallback),client);
            }

            private static void SendCallback(IAsyncResult ar)
            {
                try
                {
                    Socket client = (Socket)ar.AsyncState;
                    int byteSent = client.EndSend(ar);
                    Console.WriteLine($"Sent : {byteSent} bytes to server");
                    sendCompleted.Set(); // 모든 바이트를 보냈음을 알리는 신호
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            private static void ConnectionCallback(IAsyncResult ar)
            {
                try
                {
                    Socket client = (Socket)ar.AsyncState;
                    client.EndConnect(ar);
                    Console.WriteLine($"Socket connection : {client.RemoteEndPoint.ToString()}");
                    connectCompleted.Set();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
