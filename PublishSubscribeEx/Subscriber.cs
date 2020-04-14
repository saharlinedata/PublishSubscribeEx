using System;
using System.Collections.Generic;
using System.Text;
using NetMQ;
using NetMQ.Sockets;

namespace PublishSubscribeEx
{
    public class Subscriber
    {
        string topic;
        string messageReceived;

        public string GetMsg()
        { return messageReceived; }

        public Subscriber(string topic)
        {
            this.topic = topic;

        }

        public void Subscribe()
        {

            using (var subSocket = new SubscriberSocket())
            {
                subSocket.Connect("tcp://127.0.0.1:12345");
                subSocket.Subscribe(topic);

                while (true)
                {

                    messageReceived = subSocket.ReceiveFrameString();



                }

            }
        }

    }
}

