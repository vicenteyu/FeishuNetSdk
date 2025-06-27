// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetAcsV1UsersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取用户列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Acs.Spec;

/// <summary>
/// 测试 获取用户列表 响应体
/// <para>接口ID：6987691292973891585</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/user/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fuser%2flist</para>
/// </summary>
[TestClass]
public class Test_GetAcsV1UsersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "feature": {
                    "card": 123456,
                    "face_uploaded": true
                },
                "user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62"
            }
        ],
        "page_token": "AQD9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JKiSIkdexPw=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Acs.Spec.GetAcsV1UsersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}