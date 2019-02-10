namespace NameListSQLServer.Model
{
    using NameListSQLServer.Migrations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NameListDbContext : DbContext
    {
        // コンテキストは、アプリケーションの構成ファイル (App.config または Web.config) から 'NameListDbContext' 
        // 接続文字列を使用するように構成されています。既定では、この接続文字列は LocalDb インスタンス上
        // の 'NameListSQLServer.Model.NameListDbContext' データベースを対象としています。 
        // 
        // 別のデータベースとデータベース プロバイダーまたはそのいずれかを対象とする場合は、
        // アプリケーション構成ファイルで 'NameListDbContext' 接続文字列を変更してください。


#if DEBUG
        public NameListDbContext()
            : base("name=NameListDbContextDebug")
        {
        //自動マイグレーション
        Database.SetInitializer(new MigrateDatabaseToLatestVersion<NameListDbContext, Configuration>());
        }
#else
                  public NameListDbContext()
                      : base("name=NameListDbContextRelease")
                  {
                      Database.SetInitializer(new MigrateDatabaseToLatestVersion<NameListDbContext, Configuration>());
                  }
#endif


        // モデルに含めるエンティティ型ごとに DbSet を追加します。Code First モデルの構成および使用の
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=390109 を参照してください。

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Person> persons { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}