// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1TalentFoldersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取人才文件夹列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取人才文件夹列表 响应体
/// <para>接口ID：7054018845564796956</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_folder%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1TalentFoldersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEsInRpbWVzdGFtcCI6MTY0MDc2NTYzMjA4OCwiaWQiOm51bGx9",
        "items": [
            {
                "folder_id": "7041806543797995820",
                "folder_name": "人才文件夹A1",
                "owner_id": "ou_85bb308c57f597471cd2bb5b4f580245"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1TalentFoldersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}