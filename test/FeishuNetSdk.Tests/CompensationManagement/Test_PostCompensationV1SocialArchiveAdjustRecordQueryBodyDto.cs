// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostCompensationV1SocialArchiveAdjustRecordQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 通过员工ID批量获取社保增减员记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 通过员工ID批量获取社保增减员记录 请求体
/// <para>接口ID：7420038908975382530</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/social_archive/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fsocial_archive_adjust_record%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1SocialArchiveAdjustRecordQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id_list": [
        "7134995965475620396"
    ],
    "record_type": "increase"
}
""";
        var result = Deserialize<FeishuNetSdk.CompensationManagement.PostCompensationV1SocialArchiveAdjustRecordQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}