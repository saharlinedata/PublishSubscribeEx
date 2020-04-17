using System.Threading;
using NetMQ;
using NetMQ.Sockets;
using PublishSubscribeEx;

namespace PubCode
{
    public class Publisher
    {
        public void Publish()
        {

            using (var pubSocket = new PublisherSocket())
            {


                pubSocket.Bind("tcp://127.0.0.1:55555");
                Thread.Sleep(100);
                var msg = new BlockedOrderCreated();

                pubSocket.SendMoreFrame("BlockedOrderTopic").SendFrame(msg.content);



            }
        }
    }
}