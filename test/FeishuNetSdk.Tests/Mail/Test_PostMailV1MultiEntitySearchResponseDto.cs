// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="Test_PostMailV1MultiEntitySearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 多实体搜索 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 多实体搜索 响应体
/// <para>接口ID：7648865505080413417</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/multi_entity/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmulti_entity%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostMailV1MultiEntitySearchResponseDto : TestBase
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
                "type": "user",
                "id": "6911188411932033028",
                "name": "张三",
                "email": "zhangsan@bytedance.com",
                "display_name": "备注名",
                "member_count": 128,
                "user_id": "ou_2d131f4c3a28b0",
                "department": "飞书研发团队",
                "chat_id": "oc_40ed357053e34b9",
                "tag": "超大群/部门群/邮箱联系人/邮件组/外部"
            }
        ],
        "notice": "The query is too long and has been truncated to the first 50 characters for search."
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PostMailV1MultiEntitySearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}