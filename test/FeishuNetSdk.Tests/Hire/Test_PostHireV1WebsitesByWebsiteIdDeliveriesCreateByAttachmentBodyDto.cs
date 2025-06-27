// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1WebsitesByWebsiteIdDeliveriesCreateByAttachmentBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 根据简历附件创建招聘官网投递任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 根据简历附件创建招聘官网投递任务 请求体
/// <para>接口ID：7097131869725179905</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create_by_attachment</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-delivery%2fcreate_by_attachment</para>
/// </summary>
[TestClass]
public class Test_PostHireV1WebsitesByWebsiteIdDeliveriesCreateByAttachmentBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "job_post_id": "6960663240925956636",
    "user_id": "6960663240925956634",
    "resume_file_id": "7095614894070434092",
    "channel_id": "6891560630172518670",
    "application_preferred_city_code_list": [
        "CT_100121"
    ],
    "mobile_country_code": "+86",
    "mobile": "182900291190",
    "email": "foo@bytedance.com",
    "identification": {
        "identification_type": 1,
        "identification_number": "11002030131312312"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1WebsitesByWebsiteIdDeliveriesCreateByAttachmentBodyDto>(json);
        Assert.IsNotNull(result);
    }
}