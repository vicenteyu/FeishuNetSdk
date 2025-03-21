// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-21
//
// Last Modified By : yxr
// Last Modified On : 2025-03-21
// ************************************************************************
// <copyright file="PostPayrollV1DatasourceRecordsSaveResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建 / 更新外部算薪数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Payroll;
/// <summary>
/// 创建 / 更新外部算薪数据 响应体
/// <para>参照数据源配置字段格式，批量保存（创建或更新）数据记录。</para>
/// <para>1. 记录的唯一标志通过业务主键判断（employment_id + payroll_period）</para>
/// <para>2. 若不存在数据记录，则本次保存会插入1条记录。</para>
/// <para>3. 若已存在数据记录，则本次保存会覆盖更新已有记录（只更新传入字段的值，未传入字段值不更新），如果传入的数据记录没有任何变化，则不更新。</para>
/// <para>4. 若更新或者插入成功，会返回产生数据变更的记录条数。</para>
/// <para>接口ID：7411366924142460930</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/payroll-v1/datasource_record/save</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fdatasource_record%2fsave</para>
/// </summary>
public record PostPayrollV1DatasourceRecordsSaveResponseDto
{
    /// <summary>
    /// <para>变更的记录条数。变更包含新建或者更新记录两种操作。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("affect_counts")]
    public string AffectCounts { get; set; } = string.Empty;
}
