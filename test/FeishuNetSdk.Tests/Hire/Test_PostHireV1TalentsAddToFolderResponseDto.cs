// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1TalentsAddToFolderResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 将人才加入指定文件夹 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 将人才加入指定文件夹 响应体
/// <para>接口ID：7044465232156999708</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/add_to_folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fadd_to_folder</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentsAddToFolderResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "talent_id_list": [
            "7039620186502138157"
        ],
        "folder_id": "7039620186502138156"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1TalentsAddToFolderResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}