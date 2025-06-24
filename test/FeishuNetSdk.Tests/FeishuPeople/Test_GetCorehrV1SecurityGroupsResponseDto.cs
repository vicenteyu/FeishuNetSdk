// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1SecurityGroupsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取角色列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 批量获取角色列表 响应体
/// <para>接口ID：7088513302561128449</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/authorization/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fsecurity_group%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1SecurityGroupsResponseDto : TestBase
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
                "id": "7034393015968122400",
                "code": "department_manager",
                "name": {
                    "zh_cn": "cn",
                    "en_us": "en"
                },
                "active_status": 1,
                "description": {
                    "zh_cn": "cn",
                    "en_us": "en"
                },
                "group_type": 1,
                "created_by": "6967639606963471902",
                "update_time": "1",
                "org_truncation": [
                    {
                        "org_key": "department",
                        "type": 0,
                        "depth": 0
                    }
                ]
            }
        ],
        "has_more": true,
        "page_token": "1234452132"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1SecurityGroupsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}