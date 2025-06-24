// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1JobsByJobIdManagersBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新职位相关人员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新职位相关人员 请求体
/// <para>接口ID：7098334044387475484</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob-manager%2fbatch_update</para>
/// </summary>
[TestClass]
public class Test_PostHireV1JobsByJobIdManagersBatchUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "recruiter_id": "ou_e6139117c300506837def50545420c6a",
    "assistant_id_list": [
        "ou_808dad5b8fb21416b4ff242a5c616016"
    ],
    "hiring_manager_id_list": [
        "ou_808dad5b8fb21416b4ff242a5c616016"
    ],
    "update_option_list": [
        1
    ],
    "creator_id": "ou_efk39117c300506837def50545420c6a"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1JobsByJobIdManagersBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}