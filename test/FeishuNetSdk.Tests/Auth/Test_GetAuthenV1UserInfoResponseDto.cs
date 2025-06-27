// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetAuthenV1UserInfoResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取用户信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Auth;

/// <summary>
/// 测试 获取用户信息 响应体
/// <para>接口ID：7180265937329537028</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/login-state-management/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2fuser_info%2fget</para>
/// </summary>
[TestClass]
public class Test_GetAuthenV1UserInfoResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "name": "zhangsan",
        "en_name": "zhangsan",
        "avatar_url": "www.feishu.cn/avatar/icon",
        "avatar_thumb": "www.feishu.cn/avatar/icon_thumb",
        "avatar_middle": "www.feishu.cn/avatar/icon_middle",
        "avatar_big": "www.feishu.cn/avatar/icon_big",
        "open_id": "ou-caecc734c2e3328a62489fe0648c4b98779515d3",
        "union_id": "on-d89jhsdhjsajkda7828enjdj328ydhhw3u43yjhdj",
        "email": "zhangsan@feishu.cn",
        "enterprise_email": "demo@mail.com",
        "user_id": "5d9bdxxx",
        "mobile": "+86130002883xx",
        "tenant_key": "736588c92lxf175d",
        "employee_no": "111222333"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Auth.GetAuthenV1UserInfoResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}