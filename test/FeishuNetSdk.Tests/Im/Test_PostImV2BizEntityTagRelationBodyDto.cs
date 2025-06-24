// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostImV2BizEntityTagRelationBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 绑定标签到群 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 绑定标签到群 请求体
/// <para>接口ID：7315032956271329284</para>
/// <para>文档地址：https://open.feishu.cn/document/tenant-tag/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fbiz_entity_tag_relation%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV2BizEntityTagRelationBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "tag_biz_type": "chat",
    "biz_entity_id": "oc_xxxxx",
    "tag_ids": [
        "71616xxxx"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV2BizEntityTagRelationBodyDto>(json);
        Assert.IsNotNull(result);
    }
}