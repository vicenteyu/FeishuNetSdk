// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApplicationV6ApplicationsByAppIdVisibilityCheckWhiteBlackListBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询用户或部门是否在应用的可用或禁用名单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 查询用户或部门是否在应用的可用或禁用名单 请求体
/// <para>接口ID：7218093640928149508</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/admin/check_white_black_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-visibility%2fcheck_white_black_list</para>
/// </summary>
[TestClass]
public class Test_PostApplicationV6ApplicationsByAppIdVisibilityCheckWhiteBlackListBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_ids": [
        "ou_d317f090b7258ad0372aa53963cda70d"
    ],
    "department_ids": [
        "od-aa2c50a04769feefededb7a05b7525a8"
    ],
    "group_ids": [
        "96815a9cd9beg8g4"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PostApplicationV6ApplicationsByAppIdVisibilityCheckWhiteBlackListBodyDto>(json);
        Assert.IsNotNull(result);
    }
}