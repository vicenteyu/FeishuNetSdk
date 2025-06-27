// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1TalentsByTalentIdExternalInfoBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建人才外部信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建人才外部信息 请求体
/// <para>接口ID：7045099225022185474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create-5</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent-external_info%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentsByTalentIdExternalInfoBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "external_create_time": "1639992265035"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1TalentsByTalentIdExternalInfoBodyDto>(json);
        Assert.IsNotNull(result);
    }
}