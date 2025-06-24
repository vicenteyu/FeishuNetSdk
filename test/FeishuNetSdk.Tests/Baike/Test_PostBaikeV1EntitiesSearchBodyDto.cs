// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostBaikeV1EntitiesSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 模糊搜索词条 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 模糊搜索词条 请求体
/// <para>接口ID：7016992864837353500</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/entity/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fentity%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostBaikeV1EntitiesSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "词典",
    "classification_filter": {
        "include": [
            "7195482254012055580"
        ],
        "exclude": [
            "7195482254012055581"
        ]
    },
    "sources": [
        1
    ],
    "creators": [
        "ou_30b07b63089ea46518789914dac63d36"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Baike.PostBaikeV1EntitiesSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}