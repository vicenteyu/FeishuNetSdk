// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApplicationV6ApplicationsByAppIdVisibilityCheckWhiteBlackListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询用户或部门是否在应用的可用或禁用名单 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 查询用户或部门是否在应用的可用或禁用名单 响应体
/// <para>接口ID：7218093640928149508</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/admin/check_white_black_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-visibility%2fcheck_white_black_list</para>
/// </summary>
[TestClass]
public class Test_PostApplicationV6ApplicationsByAppIdVisibilityCheckWhiteBlackListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_visibility_list": [
            {
                "user_id": "ou_d317f090b7258ad0372aa53963cda70d",
                "in_white_list": false,
                "in_black_list": false,
                "in_paid_list": false
            }
        ],
        "department_visibility_list": [
            {
                "department_id": "od-aa2c50a04769feefededb7a05b7525a8",
                "in_white_list": false,
                "in_black_list": false
            }
        ],
        "group_visibility_list": [
            {
                "group_id": "96815a9cd9beg8g4",
                "in_white_list": false,
                "in_black_list": false
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.PostApplicationV6ApplicationsByAppIdVisibilityCheckWhiteBlackListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}