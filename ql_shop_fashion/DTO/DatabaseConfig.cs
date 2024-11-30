using System;
using System.IO;
using System.Text.Json;

namespace DTO
{
    public static class DatabaseConfig
    {
        // Đường dẫn tới file JSON để lưu chuỗi kết nối
        private static readonly string ConfigFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DatabaseConfig.json");

        // Chuỗi kết nối toàn cục
        public static string ConnectionString { get; private set; } = string.Empty;

        /// <summary>
        /// Tải chuỗi kết nối từ file JSON
        /// </summary>
        public static void LoadConnectionString()
        {
            try
            {
                // Kiểm tra file JSON có tồn tại không
                if (!File.Exists(ConfigFilePath))
                {
                    throw new FileNotFoundException("File cấu hình không tồn tại.");
                }

                // Đọc nội dung file JSON
                var jsonData = File.ReadAllText(ConfigFilePath);
                var config = JsonSerializer.Deserialize<ConfigModel>(jsonData);

                // Kiểm tra giá trị chuỗi kết nối
                if (config == null || string.IsNullOrWhiteSpace(config.ConnectionString))
                {
                    throw new Exception("Chuỗi kết nối chưa được cấu hình trong file.");
                }

                // Gán chuỗi kết nối
                ConnectionString = config.ConnectionString;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tải chuỗi kết nối: {ex.Message}");
            }
        }

        /// <summary>
        /// Lưu chuỗi kết nối vào file JSON
        /// </summary>
        /// <param name="newConnectionString">Chuỗi kết nối mới</param>
        public static void SaveConnectionString(string newConnectionString)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(newConnectionString))
                {
                    throw new ArgumentException("Chuỗi kết nối không được để trống.");
                }

                // Tạo model để lưu chuỗi kết nối
                var config = new ConfigModel { ConnectionString = newConnectionString };

                // Ghi model vào file JSON
                var jsonData = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(ConfigFilePath, jsonData);

                // Cập nhật giá trị ConnectionString toàn cục
                ConnectionString = newConnectionString;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lưu chuỗi kết nối: {ex.Message}");
            }
        }

        // Lớp đại diện cho file cấu hình JSON
        private class ConfigModel
        {
            public string ConnectionString { get; set; }
        }
    }
}
