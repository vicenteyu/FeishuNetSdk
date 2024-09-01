// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="AcsUserUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>用户信息变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Acs.Events;
/// <summary>
/// 用户信息变更 事件体
/// <para>智能门禁用户特征值变化时，发送此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=acs&amp;version=v1&amp;resource=user&amp;event=updated)</para>
/// <para>接口ID：6987691292973907969</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/user/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fuser%2fevents%2fupdated</para>
/// </summary>
public record AcsUserUpdatedV1EventBodyDto() : EventBodyDto("acs.user.updated_v1")
{
    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public UserIdSuffix? UserId { get; set; }

    /// <summary>
    /// <para>卡号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("card")]
    public int? Card { get; set; }

    /// <summary>
    /// <para>是否上传人脸图片</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("face_uploaded")]
    public bool? FaceUploaded { get; set; }
}
