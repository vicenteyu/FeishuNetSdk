// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2024-09-07
// ************************************************************************
// <copyright file="FrameProto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>飞书WebSocket序列化消息类</summary>
// ************************************************************************
using ProtoBuf;
using System.Text;

namespace FeishuNetSdk.WebSocket
{
    /// <summary>
    /// 
    /// </summary>
    [ProtoContract]
    public class Header
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1, Name = "key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2, Name = "value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// 
    /// </summary>
    [ProtoContract]
    public class Frame
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public ulong SeqID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public ulong LogID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3, Name = "service")]
        public int Service { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4, Name = "method")]
        public int Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5, Name = "headers")]
        public Header[]? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6, Name = "payload_encoding")]
        public string? PayloadEncoding { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7, Name = "payload_type")]
        public string? PayloadType { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8, Name = "payload")]
        public byte[]? Payload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        public string? LogIDNew { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string? PayloadToJson() => Payload is null ? null : Encoding.UTF8.GetString(Payload);

        /// <summary>
        /// 
        /// </summary>
        public MessageType MessageType
        {
            get
            {
                if (Headers is null || Headers.Length == 0) return MessageType.Unknown;
                if (Headers.Any(p => p.Key == "type" && p.Value == "ping")) return MessageType.Ping;
                if (Headers.Any(p => p.Key == "type" && p.Value == "pong")) return MessageType.Pong;
                if (Headers.Any(p => p.Key == "type" && p.Value == "card")) return MessageType.Card;
                if (Headers.Any(p => p.Key == "type" && p.Value == "event")) return MessageType.Event;
                return MessageType.Unknown;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Ping,

        /// <summary>
        /// 
        /// </summary>
        Pong,

        /// <summary>
        /// 
        /// </summary>
        Card,

        /// <summary>
        /// 
        /// </summary>
        Event,

        /// <summary>
        /// 
        /// </summary>
        Unknown
    }
}
