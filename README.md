# MCP (Model Context Protocol) 使用 C# 的入門指南

本指南將帶您逐步了解如何在 C# 中使用 MCP (Model Context Protocol)。

## 目錄
1. [前置準備](#前置準備)
2. [安裝必要套件](#安裝必要套件)
3. [建立 MCP 客戶端](#建立-mcp-客戶端)
4. [實現基本操作](#實現基本操作)
5. [測試與驗證](#測試與驗證)

---

## 前置準備

1. 確保已安裝以下工具：
    - Visual Studio 或其他 C# 開發環境
    - .NET 8 或更新版本的 SDK
2. Clone 本 repository 至本地環境：
    ```bash
    git clone <repository-url>
    cd MCPServerLab
    ```

---

## 安裝必要套件

1. 開啟專案目錄，並執行以下命令以新增必要的 NuGet 套件：
    ```bash
    dotnet add package ModelContextProtocol --version 0.1.0-preview.11
    dotnet add package Microsoft.Extensions.Hosting
    ```

2. 確保 `csproj` 文件中已正確引用這些套件。

---

## 建立 MCP 客戶端

1. 新增一個類別檔案 `HelloWorldToolInstance.cs`。
2. 實現 MCP 客戶端的基本結構：
    ```csharp
    [McpServerToolType]
    public class HelloWorldToolInstance
    {
        [McpServerTool, Description("Hello World Tool")]
        public string GetYourCityName(string city) =>
            $"Hello! Wellcome to {city}!";
    }
    ```

---

## 實現基本操作

使用 npx 叫起 dotnet run

$ npx @modelcontextprotocol/inspector dotnet run

---

## 測試與驗證

1. 藉由 inspector UI Tool 確認 MCP 請求是否成功。
2. 根據測試結果調整程式碼。

---

## 結語

透過以上步驟，您已成功在 C# 中實現 MCP 的基本操作。如需進一步擴展，請參考本 repository 的 Source Code 或相關文件。
