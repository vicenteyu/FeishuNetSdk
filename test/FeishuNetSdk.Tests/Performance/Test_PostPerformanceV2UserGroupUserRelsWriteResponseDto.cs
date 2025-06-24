// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPerformanceV2UserGroupUserRelsWriteResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新人员组成员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 更新人员组成员 响应体
/// <para>接口ID：7381506957100875778</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/user_group_user_rel/write</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fuser_group_user_rel%2fwrite</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2UserGroupUserRelsWriteResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "data": {
            "success_user_ids": [
                "ou_a9dc8d009fd5395c22c7e040e0130692"
            ],
            "fail_user_datas": [
                {
                    "user_id": "ou_ff77dba046431fc53ea21a0095df82f4",
                    "fail_code": 1
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV2UserGroupUserRelsWriteResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}