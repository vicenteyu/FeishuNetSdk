// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostLingoV1EntitiesMatchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 精准搜索词条 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 精准搜索词条 响应体
/// <para>接口ID：7249689905697079324</para>
/// <para>文档地址：https://open.feishu.cn/document/lingo-v1/entity/match</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fentity%2fmatch</para>
/// </summary>
[TestClass]
public class Test_PostLingoV1EntitiesMatchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "results": [
            {
                "entity_id": "enterprise_34***584",
                "type": 0
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Baike.PostLingoV1EntitiesMatchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}