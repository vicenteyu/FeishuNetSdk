// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutImV2ChatButtonResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新消息流卡片按钮 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 更新消息流卡片按钮 响应体
/// <para>为群组消息、机器人消息的消息流卡片添加、更新、删除快捷操作按钮。</para>
/// <para>接口ID：7302258202712506396</para>
/// <para>文档地址：https://open.feishu.cn/document/im-v2/groups-bots/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fchat_button%2fupdate</para>
/// </summary>
public record PutImV2ChatButtonResponseDto
{
    /// <summary>
    /// <para>失败的用户</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("failed_user_reasons")]
    public FailedReason[]? FailedUserReasons { get; set; }

    /// <summary>
    /// <para>失败的用户</para>
    /// </summary>
    public record FailedReason
    {
        /// <summary>
        /// <para>错误码</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// <para>错误信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：The user is not in the chat</para>
        /// </summary>
        [JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// <para>用户id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_679eaeb583654bff73fefcc6e6371301</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
    }
}
