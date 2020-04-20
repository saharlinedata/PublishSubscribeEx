using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using NetMQ;
using NetMQ.Sockets;

namespace SubscribeCode
{
    public class Subscriber
    {
        private string topic { get; set; }
        string messageReceived;


        public void SetTopic(string topicName)
        {
            topic = topicName;
        }


        public string GetMsg()
        {
            return messageReceived;
        }



        public void Subscribe()
        {

            using (var subSocket = new SubscriberSocket())
            {
                subSocket.Connect("tcp://127.0.0.1:55555");
                Thread.Sleep(500);
                subSocket.Subscribe(topic);
                Thread.Sleep(100);
                while (true)
                {


                    Thread.Sleep(500);
                    messageReceived = subSocket.ReceiveFrameString();
                    Debug.WriteLine(messageReceived);
                }
            }

            /* // messageReceived = subSocket.ReceiveFrameString();
             for (int i = 0; i < 10; i++)
             {



             messageReceived = subSocket.ReceiveFrameString();

                Thread.Sleep(100);
                 if (messageReceived !=null)
                     return;

            }
            *
         }*/
        }
    }
}