// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-18
//
// Last Modified By : yxr
// Last Modified On : 2025-10-18
// ************************************************************************
// <copyright file="Test_GetCorehrV2DraftsByDraftIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 根据组织架构调整 ID 查询发起的流程信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 根据组织架构调整 ID 查询发起的流程信息 响应体
/// <para>接口ID：7428890785897218049</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdraft%2fget</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2DraftsByDraftIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "draft_id": "6991776076699549697",
        "draft_status": "1",
        "process_infos": [
            {
                "process_id": "6991776076699549697",
                "approval_group_status": "1"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2DraftsByDraftIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}