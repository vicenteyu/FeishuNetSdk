namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 查询所有任务 响应体
/// <para>接口ID：7044355281854070812</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2flist</para>
/// </summary>
[TestClass]
public class Test_GetTaskV1TasksResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "has_more": true,
        "items": [
            {
                "can_edit": true,
                "collaborators": [
                    {
                        "id": "ou_842f5b9b4b8faa60570e9008acc9af1f"
                    }
                ],
                "complete_time": "1637119864",
                "create_time": "1637045612",
                "creator_id": "ou_5df8b925054285f7166bf8b6ff03341f",
                "custom": "",
                "description": "多吃水果，多运动，健康生活，快乐工作。",
                "due": {
                    "time": "1637137860",
                    "timezone": "Asia/Shanghai"
                },
                "extra": "dGVzdA==",
                "followers": [
                    {
                        "id": "ou_842f5b9b4b8faa60570e9008acc9af1f"
                    }
                ],
                "id": "11d42f77-cfa4-4833-a76e-ad778b081077",
                "origin": {
                    "href": {
                        "title": "反馈一个问题，需要协助排查",
                        "url": "https://support.feishu.com/internal/foo-bar"
                    },
                    "platform_i18n_name": "{\"en_us\":\"IT Workspace\",\"zh_cn\":\"IT 工作台\"}"
                },
                "source": 6,
                "summary": "少喝咖啡",
                "update_time": "1637119866"
            },
            {
                "collaborators": [
                    {
                        "id": "ou_842f5b9b4b8faa60570e9008acc9af1f"
                    }
                ],
                "complete_time": "1636965009",
                "create_time": "1632886899",
                "creator_id": "ou_5df8b925054285f7166bf8b6ff03341f",
                "custom": "",
                "description": "",
                "due": {
                    "time": "0",
                    "timezone": ""
                },
                "extra": "",
                "followers": [
                    {
                        "id": "ou_842f5b9b4b8faa60570e9008acc9af1f"
                    }
                ],
                "id": "692ec13b-613d-4d0b-818d-a34ae2cb1413",
                "origin": {
                    "href": {},
                    "platform_i18n_name": "null"
                },
                "source": 1,
                "summary": "多喝热水",
                "update_time": "1636965011",
                "repeat_rule": "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR"
            }
        ],
        "page_token": "MTYzMTg3ODUxNQ=="
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.GetTaskV1TasksResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}