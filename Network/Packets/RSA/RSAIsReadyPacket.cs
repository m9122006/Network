﻿#region Licence - LGPLv3
// ***********************************************************************
// Assembly         : Network
// Author           : Thomas
// Created          : 29.09.2018
//
// Last Modified By : Thomas
// Last Modified On : 29.09.2018
// ***********************************************************************
// <copyright>
// Company: Indie-Dev
// Thomas Christof (c) 2018
// </copyright>
// <License>
// GNU LESSER GENERAL PUBLIC LICENSE
// </License>
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
// ***********************************************************************
#endregion Licence - LGPLv3
using Network.Attributes;

namespace Network.Packets.RSA
{
    /// <summary>
    /// Packet to indicate that the communication partner 
    /// is ready for an encrypted communication.
    /// </summary>
    /// <seealso cref="Network.Packet" />
    [PacketType(20)]
    internal class RSAIsReadyPacket : RequestPacket
    {
        public RSAIsReadyPacket() { }
    }
}