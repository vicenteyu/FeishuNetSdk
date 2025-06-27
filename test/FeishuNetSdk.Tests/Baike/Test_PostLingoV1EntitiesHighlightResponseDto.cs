// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostLingoV1EntitiesHighlightResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 词条高亮 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 词条高亮 响应体
/// <para>接口ID：7249689905697210396</para>
/// <para>文档地址：https://open.feishu.cn/document/lingo-v1/entity/highlight</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fentity%2fhighlight</para>
/// </summary>
[TestClass]
public class Test_PostLingoV1EntitiesHighlightResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "phrases": [
            {
                "name": "词典",
                "entity_ids": [
                    "enterprise_348***84"
                ],
                "span": {
                    "start": 0,
                    "end": 2
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Baike.PostLingoV1EntitiesHighlightResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}