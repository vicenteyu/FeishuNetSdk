// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2JobFamiliesBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 通过序列 ID 批量获取序列信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 根据条件批量获取序列信息 请求体
/// <para>接口ID：7252157701853216796</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_family/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_family%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2JobFamiliesBatchGetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
   "job_family_ids": [
    "7485328827867711096",
    "7486375838641787444"
    ],
  "job_family_codes": [
    "code1110",
    "code1112",
    "code1114"
  ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2JobFamiliesBatchGetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}