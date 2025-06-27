// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetBotV3InfoResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取机器人信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application.Spec;

/// <summary>
/// 测试 获取机器人信息 响应体
/// <para>接口ID：6907569745299111938</para>
/// <para>文档地址：https://open.feishu.cn/document/client-docs/bot-v3/obtain-bot-info</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAjMxEjLwITMx4CMyETM</para>
/// </summary>
[TestClass]
public class Test_GetBotV3InfoResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"ok",
    "bot":{
        "activate_status":2,
        "app_name":"name",
        "avatar_url":"https://s1-imfile.feishucdn.com/static-resource/v1/da5xxxx14b16113",
        "ip_white_list":[

        ],
        "open_id":"ou_e6e14f667cfe239d7b129b521dce0569"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Application.Spec.GetBotV3InfoResponseDto>(json);
        Assert.IsNotNull(result);
    }
}