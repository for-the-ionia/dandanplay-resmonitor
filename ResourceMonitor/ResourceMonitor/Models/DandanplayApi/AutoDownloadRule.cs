using System;

namespace ResourceMonitor.Models.DandanplayApi
{
    /*
     * {
      "id": "string",
      "description": "string",
      "keyword": "string",
      "subgroupId": 0,
      "typeId": 0,
      "maxCount": 0,
      "autoStart": true,
      "createdTime": "2020-06-21T09:30:22.124Z",
      "startTime": "2020-06-21T09:30:22.124Z",
      "subgroupName": "string",
      "typeName": "string",
      "chooseNewerIfDuplicate": true,
      "limitFileSize": 0,
      "version": 0,
      "isShared": true
    }
     */
    
    /// <summary>
    /// 下载规则详情（部分属性没有用到就没加进来）
    /// </summary>
    public class AutoDownloadRule
    {
        public string id { get; set; }
        public string description { get; set; }
        public string keyword { get; set; }
        public int subgroupId { get; set; }
        public int typeId { get; set; }
        public int maxCount { get; set; }
        public bool autoStart { get; set; }
        public DateTime createdTime { get; set; }
        public string subgroupName { get; set; }
        public string typeName { get; set; }
        public bool chooseNewerIfDuplicate { get; set; }
        public int limitFileSize { get; set; }
        public int version { get; set; }
    }
}