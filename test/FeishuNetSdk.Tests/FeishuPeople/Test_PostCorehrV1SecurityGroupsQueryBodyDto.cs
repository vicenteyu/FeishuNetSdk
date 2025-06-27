// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1SecurityGroupsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询部门 / 地点的 HRBP / 属地 BP 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 查询部门 / 地点的 HRBP / 属地 BP 请求体
/// <para>接口ID：7089329362222448644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/authorization/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fsecurity_group%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1SecurityGroupsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "item_list": [
        {
            "role_key": "location_bp",
            "department_id": "7063072995761456670",
            "work_location_id": "6892687221355185677"
        }
    ],
    "updated_at_gte": "1729773628",
    "updated_at_lte": "1729773628"
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1SecurityGroupsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}