using SendBird;
using System;
using System.Collections.Generic;

namespace TestChat
{
    class Program
    {
        static void Main(string[] args)
        {
            SendBirdClient.Init("52C4347B-C9B0-4E62-81D6-96EB40517902");

            //SendBirdClient.Connect("tom", (User user, SendBirdException e) =>
            //{
            //    if (e != null)
            //    {
            //        // Error
            //        return;
            //    }
            //});

            OpenChannel.GetChannel("sendbird_open_channel_43739_172b1997dcc4c9bbfc49bc0533303c8017bb2d70", (OpenChannel openChannel, SendBirdException e) => {
                if (e != null)
                {
                    // Error!
                    return;
                }

                Console.WriteLine("canale aperto");
                // Successfully fetched the channel.
                // Do something with openChannel.
            });

            Console.Read();
        }
    }
}
