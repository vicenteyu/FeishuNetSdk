// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1AssignedUsersSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取组织类角色授权列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 获取组织类角色授权列表 响应体
/// <para>接口ID：7141207412454998019</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/authorization/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fassigned_user%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1AssignedUsersSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "employment_id": "6967639606963471902",
                "management_scope_list": [
                    {
                        "management_dimension": "department",
                        "obj_id": "7023318326176777742"
                    }
                ]
            }
        ],
        "has_more": true,
        "page_token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1AssignedUsersSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}