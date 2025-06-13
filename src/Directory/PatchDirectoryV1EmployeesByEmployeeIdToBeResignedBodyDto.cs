// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PatchDirectoryV1EmployeesByEmployeeIdToBeResignedBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新在职员工为待离职 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 更新在职员工为待离职 请求体
/// <para>本接口用于为在职员工办理离职，将其更新为「待离职」状态。「待离职」员工不会自动离职，需要使用「离职员工」API操作离职和资源转交。</para>
/// <para>使用user_access_token时默认为管理员用户，仅「人事管理模式」的管理员可操作。</para>
/// <para>接口ID：7390661486131707906</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/to_be_resigned</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fto_be_resigned</para>
/// </summary>
public record PatchDirectoryV1EmployeesByEmployeeIdToBeResignedBodyDto
{
    /// <summary>
    /// <para>在职员工流转到待离职</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("employee")]
    public SetEmployeePreResigned Employee { get; set; } = new();

    /// <summary>
    /// <para>在职员工流转到待离职</para>
    /// </summary>
    public record SetEmployeePreResigned
    {
        /// <summary>
        /// <para>离职日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：2024-06-21</para>
        /// </summary>
        [JsonPropertyName("resign_date")]
        public string ResignDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>离职原因</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：薪酬不符合预期</item>
        /// <item>2：工作时间过长</item>
        /// <item>3：不满意工作内容</item>
        /// <item>4：不认可上级或管理层</item>
        /// <item>5：职业发展机会有限</item>
        /// <item>6：对公司文化缺乏认同</item>
        /// <item>7：组织架构调整（主动离职）</item>
        /// <item>8：合同到期</item>
        /// <item>9：跳槽</item>
        /// <item>10：转行</item>
        /// <item>11：家庭原因</item>
        /// <item>12：健康状况不佳</item>
        /// <item>13：工作地点原因</item>
        /// <item>14：其他(主动离职)</item>
        /// <item>15：意外</item>
        /// <item>16：身故</item>
        /// <item>17：解雇</item>
        /// <item>18：试用期不通过</item>
        /// <item>19：工作表现不佳</item>
        /// <item>20：工作产出低</item>
        /// <item>21：组织架构调整（被动离职）</item>
        /// <item>22：违纪</item>
        /// <item>23：违法</item>
        /// <item>24：其他（被动离职）</item>
        /// <item>25：其他（其他）</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("resign_reason")]
        public string ResignReason { get; set; } = string.Empty;

        /// <summary>
        /// <para>离职类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：主动</item>
        /// <item>2：被动</item>
        /// <item>3：其他</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("resign_type")]
        public string ResignType { get; set; } = string.Empty;

        /// <summary>
        /// <para>离职备注</para>
        /// <para>必填：否</para>
        /// <para>示例值：留学深造</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("resign_remark")]
        public string? ResignRemark { get; set; }
    }
}
