using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询部门 / 地点的 HRBP / 属地 BP 请求体
/// <para>通过部门或工作地点，查询对应的 HRBP / 属地 BP。</para>
/// <para>接口ID：7089329362222448644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/authorization/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fsecurity_group%2fquery</para>
/// </summary>
public record PostCorehrV1SecurityGroupsQueryBodyDto
{
    /// <summary>
    /// <para>角色列表，一次最多支持查询 50 个</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("item_list")]
    public BpRoleOrganization[] ItemLists { get; set; } = Array.Empty<BpRoleOrganization>();

    /// <summary>
    /// <para>角色列表，一次最多支持查询 50 个</para>
    /// </summary>
    public record BpRoleOrganization
    {
        /// <summary>
        /// <para>角色类型的唯一标识</para>
        /// <para>- HRBP：与部门有关，role_key 固定为 「hrbp」</para>
        /// <para>- 属地 BP：与部门、工作地点有关，role_key 固定为 「location_bp」</para>
        /// <para>必填：是</para>
        /// <para>示例值：location_bp</para>
        /// </summary>
        [JsonProperty("role_key")]
        public string RoleKey { get; set; } = string.Empty;

        /// <summary>
        /// <para>部门 ID，查询 HRBP 需输入部门 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7063072995761456670</para>
        /// </summary>
        [JsonProperty("department_id")]
        public string DepartmentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>工作地点 ID，查询属地 BP 需要输入部门 ID 与 工作地点 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6892687221355185677</para>
        /// </summary>
        [JsonProperty("work_location_id")]
        public string? WorkLocationId { get; set; }
    }
}
