// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_GetOkrV2ObjectivesByObjectiveIdAlignmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取目标的对齐信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 获取目标的对齐信息 响应体
/// <para>接口ID：7644764969658223564</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-objective-alignment/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-objective-alignment%2flist</para>
/// </summary>
[TestClass]
public class Test_GetOkrV2ObjectivesByObjectiveIdAlignmentsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "items": [
            {
                "id": "7342342398472398471",
                "create_time": "1760604634563",
                "update_time": "1760604634563",
                "from_owner": {
                    "owner_type": "user",
                    "user_id": "ou_3bbe8a09c20e89cce9bff989ed840674"
                },
                "to_owner": {
                    "owner_type": "user",
                    "user_id": "ou_3bbe8a09c20e89cce9bff989ed840674"
                },
                "from_entity_type": 2,
                "from_entity_id": "7342342398472398472",
                "to_entity_type": 2,
                "to_entity_id": "7342342398472398473"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.GetOkrV2ObjectivesByObjectiveIdAlignmentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}