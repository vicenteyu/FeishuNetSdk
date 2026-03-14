// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-14
//
// Last Modified By : yxr
// Last Modified On : 2026-03-14
// ************************************************************************
// <copyright file="PostApprovalV4DistrictsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索地理库信息 请求体文档</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 搜索地理库信息 请求体
/// <para>搜索审批的地理库数据，可用于在发起审批时填写地址控件的区域信息</para>
/// <para>接口ID：7579169568158502093</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/district/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fdistrict%2fsearch</para>
/// </summary>
public record PostApprovalV4DistrictsSearchBodyDto
{
    /// <summary>
    /// <para>根据ID查询指定区域的信息，ID即地理库数据的ID，如果传了该参数，则以该参数作为唯一筛选项</para>
    /// <para>必填：否</para>
    /// <para>最大长度：30</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("district_ids")]
    public string[]? DistrictIds { get; set; }

    /// <summary>
    /// <para>关键字，用于模糊查询符合条件的地址信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：北京</para>
    /// </summary>
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }
}
