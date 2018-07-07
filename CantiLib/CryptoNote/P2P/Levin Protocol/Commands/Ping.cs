﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Canti.CryptoNote.P2P.Commands
{
    internal class CommandPing
    {
        // Command ID
        internal const int Id = Globals.P2P_COMMANDS_POOL_BASE + 3;

        // Outgoing request structure
        internal struct Request : ICommandRequestBase
        {
            // Serializes request data into a byte array
            public byte[] Serialize()
            {
                // Not implemented yet
                return new byte[0];
            }
        }

        // Incoming response structure
        internal struct Response : ICommandResponseBase<Response>
        {
            // Variables
            internal string Status;
            internal ulong PeerId;

            // Deseriaizes response data
            public Response Deserialize(byte[] Data)
            {
                // Not implemented yet
                // Deserialize data

                // Populate and return new response
                return new Response
                {
                    Status = "OK",
                    PeerId = 0
                };
            }
        }
    }
}