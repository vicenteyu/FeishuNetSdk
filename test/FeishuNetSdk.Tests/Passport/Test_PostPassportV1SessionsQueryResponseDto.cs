// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPassportV1SessionsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取脱敏的用户登录信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Passport;

/// <summary>
/// 测试 批量获取脱敏的用户登录信息 响应体
/// <para>接口ID：7096084771490578433</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/login-state-management/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpassport-v1%2fsession%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPassportV1SessionsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "data":{
        "mask_sessions":[
            {
                "create_time":"1644980493",
                "terminal_type":2,
                "user_id":"47f183f1f1",
                "sid":"ABBAAAAAAANll6nQoIAAFA=="
            },
            {
                "create_time":"1644983127",
                "terminal_type":2,
                "user_id":"47f183ff1",
                "sid":"ACCAAAAAAANll6nQoIAAFA=="
            },
            {
                "create_time":"1644983127",
                "terminal_type":2,
                "user_id":"47f183ff2",
                "sid":"BBBAAAAAAANll6nQoIAAFA=="
            }
        ]
    },
    "msg":""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Passport.PostPassportV1SessionsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}