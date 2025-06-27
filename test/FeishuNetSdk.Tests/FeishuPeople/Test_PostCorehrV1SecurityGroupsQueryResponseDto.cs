// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1SecurityGroupsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询部门 / 地点的 HRBP / 属地 BP 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 查询部门 / 地点的 HRBP / 属地 BP 响应体
/// <para>接口ID：7089329362222448644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/authorization/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fsecurity_group%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1SecurityGroupsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "hrbp_list": [
            {
                "employment_id_list": [
                    "['7063072995761456670']"
                ],
                "department_id": "7063072995761456670",
                "work_location_id": "6892687221355185677"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1SecurityGroupsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}