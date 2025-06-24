// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1InterviewRecordsAttachmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取面试记录附件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取面试记录附件 响应体
/// <para>接口ID：7215583964449849372</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/interview/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterview_record-attachment%2fget</para>
/// </summary>
[TestClass]
public class Test_GetHireV1InterviewRecordsAttachmentsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "SUCCESS",
    "data": {
        "attachment": {
            "id": "6949805467799537964",
            "url": "https://hire.feishu.cn/blob/xx/",
            "name": "张先生-面试记录.pdf",
            "mime": "application/pdf",
            "create_time": "1618899376480"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1InterviewRecordsAttachmentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}