// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-11-27
// ************************************************************************
// <copyright file="PostApprovalV4InstancesByInstanceIdCommentsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建评论 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 创建评论 请求体
/// <para>在指定审批实例下创建、修改评论或回复评论（不包含审批同意、拒绝、转交等附加的理由或意见）。</para>
/// <para>接口ID：7117964632137154563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance-comment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance-comment%2fcreate</para>
/// </summary>
public record PostApprovalV4InstancesByInstanceIdCommentsBodyDto
{
    /// <summary>
    /// <para>评论内容，JSON 格式，传入时需要压缩转义为字符串。以下示例值未转义，你可参考请求体示例中的示例 content 进行编辑。</para>
    /// <para>**JSON 内参数说明**：</para>
    /// <para>- text：string 类型，评论文本内容。</para>
    /// <para>- files：Attachment[] 类型，附件信息。</para>
    /// <para>- url：string 类型，附件链接。</para>
    /// <para>- thumbnailURL：string 类型，缩略图链接。</para>
    /// <para>- fileSize：int64 类型，文件大小。</para>
    /// <para>- title：string 类型，标题。</para>
    /// <para>- type：string 类型，附件类型，取值 image 表示图片类型。</para>
    /// <para>**注意**：</para>
    /// <para>- 如需 @用户，则需要在该参数内设置用户名的文本，例如 `@username`，同时通过 at_info_list 参数实现 @ 效果。</para>
    /// <para>- 对于附件，在 PC 端使用 HTTP 资源链接传图片资源可能会导致缩略图异常，建议使用 HTTPS 传资源附件。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"text\":\"@username艾特展示\",\"files\":[{\"url\":\"xxx\",\"fileSize\":155149,\"title\":\"9a9fedc5cfb01a4a20c715098.png\",\"type\":\"image\",\"extra\":\"\"}]}</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// <para>评论中艾特人信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("at_info_list")]
    public CommentAtInfo[]? AtInfoLists { get; set; }

    /// <summary>
    /// <para>评论中艾特人信息</para>
    /// </summary>
    public record CommentAtInfo
    {
        /// <summary>
        /// <para>被艾特人的 ID，ID 类型与查询参数 user_id_type 取值一致。</para>
        /// <para>必填：是</para>
        /// <para>示例值：579fd9c4</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>被艾特人的姓名</para>
        /// <para>必填：是</para>
        /// <para>示例值：张敏</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>被艾特人在评论中的位置，从 0 开始。用于偏移覆盖。例如：</para>
        /// <para>- 取值为 0 时的效果：@username 示例文本</para>
        /// <para>- 取值为 2 时的效果：示例 @username 文本</para>
        /// <para>- 取值为 4 时的效果：示例文本 @username</para>
        /// <para>**注意**：该参数生效方式是覆盖生效，因此你需要先通过 content 参数设置用户名称的文本内容，然后再通过该参数将实际生效的@效果覆盖到用户名称的文本内容上。</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("offset")]
        public string Offset { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>父评论 ID，如果是回复评论，需要传入该值。获取方式：</para>
    /// <para>- 调用当前接口成功后会返回本次评论的 ID，你可以保存用于下次使用。</para>
    /// <para>- 调用[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance-comment/list)接口，获取评论 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：7081516627711524883</para>
    /// </summary>
    [JsonPropertyName("parent_comment_id")]
    public string? ParentCommentId { get; set; }

    /// <summary>
    /// <para>评论 ID。如果需要编辑、删除一条评论，则需要将该评论的 ID 传入当前参数。获取方式：</para>
    /// <para>- 调用当前接口成功后会返回本次评论的 ID，你可以保存用于下次使用。</para>
    /// <para>- 调用[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance-comment/list)接口，获取评论 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：7081516627711524883</para>
    /// </summary>
    [JsonPropertyName("comment_id")]
    public string? CommentId { get; set; }

    /// <summary>
    /// <para>是否不启用 Bot，取值为 true 时只同步数据，不触发 Bot。</para>
    /// <para>**说明**：飞书审批中自定义审批填写 false，其他情况填写 true。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("disable_bot")]
    public bool? DisableBot { get; set; }

    /// <summary>
    /// <para>附加字段，JSON 格式，传入时需要压缩转义为字符串。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"a\":\"a\"}</para>
    /// </summary>
    [JsonPropertyName("extra")]
    public string? Extra { get; set; }
}
