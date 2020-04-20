using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NetMQ;
using NetMQ.Sockets;

namespace SubCode
{
    public class Subscriber
    {
        string topic;
        string messageReceived;

        public string GetMsg()
        {
            return messageReceived;
        }

        public void SetTopic(string topicName)
        {
            topic = topicName;

        }

        public void Subscribe()
        {
            using (var subSocket = new SubscriberSocket())
            {
                subSocket.Connect("tcp://127.0.0.1:55555");
                Thread.Sleep(100);
                subSocket.Subscribe(topic);


                while (true)
                {

                    messageReceived = subSocket.ReceiveFrameString();



                }

            }

        }
    }
}
