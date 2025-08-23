// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostCorehrV2JobsBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 根据条件批量获取职务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 根据条件批量获取职务 请求体
/// <para>接口ID：7525709902931836932</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2JobsBatchGetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "job_ids": [
        "1522315"
    ],
    "job_codes": [
        "1332715"
    ],
    "fields": [
        "job_name"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2JobsBatchGetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}