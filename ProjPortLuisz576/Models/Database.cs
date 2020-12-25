using Etapa_3.Models;
using System.Collections.Generic;
using MySqlConnector;
using System;

public class Database{

   private string enderecoConexao = "Database=Luisz576;Data Source=localhost;User Id=root;";
   private int itensByPage = 3;
   
   /*Public no login*/
   public bool Login(string l, string s) => LoginIsEqual(l, s); 
   public List<Projeto> PGetProjetos() => GetProjetos();
   public List<ItemCurriculo> PGetItemsCurriculo() => GetItemsCurriculo();
   public bool PNewOrcamento(OrcamentoPedido o) => NewOrcamento(o);

   public List<OrcamentoPedido> PGetOrcamentos(bool b) => GetOrcamentos(b);
   public OrcamentoPedido PGetOrcamento(int id) => GetOrcamento(id);
   public bool PReadedOrcamento(int id) => ReadedOrcamento(id);
   public bool PNewCurriculoItem(ItemCurriculo i) => NewCurriculoItem(i);
   public bool PRemoveCurriculoItem(int id) => RemoveCurriculoItem(id);
   public bool PNewProjeto(Projeto p) => NewProjeto(p);
   public bool PRemoveProjeto(int id) => RemoveProjeto(id);
   public bool PNewBlogItem(BlogItem b) => NewBlogItem(b);
   public bool PRemoveItemBlog(int id) => RemoveItemBlog(id);
   public BlogItem PGetBlogItem(int id) => GetBlogItem(id);
   public bool PUpdateItemBlog(BlogItem b) => UpdateItemBlog(b);
   public List<BlogItem> PGetPageBlog(int page) => GetPageBlog(page);
   public bool PHasNextPage(int page) => HasNextPage(page);
   

   /*Public login*/

   /*GETs*/
   private List<Projeto> GetProjetos(){
      string query = "SELECT * FROM projetos ORDER BY id DESC";
      List<Projeto> projetos = new List<Projeto>();
      Tuple<MySqlConnection, MySqlDataReader> select = SelectFromDatabase(query);
      if(select != null){
         if(select.Item2.HasRows)
            while(select.Item2.Read())
               projetos.Add(GetProjetoFromData(select.Item2));
         select.Item2.Close();
         select.Item1.Close();
      }
      return projetos;
   }

   private List<ItemCurriculo> GetItemsCurriculo(){
      string query = "SELECT * FROM curriculo ORDER BY titulo";
      List<ItemCurriculo> items = new List<ItemCurriculo>();
      Tuple<MySqlConnection, MySqlDataReader> select = SelectFromDatabase(query);
      if(select != null){
         if(select.Item2.HasRows)
            while(select.Item2.Read())
               items.Add(GetItemCurriculoFromData(select.Item2));
         select.Item2.Close();
         select.Item1.Close();
      }
      return items;
   }

   private List<OrcamentoPedido> GetOrcamentos(bool b){
      string query;
      if(!b)
         query = "SELECT * FROM orcamento WHERE lido = false ORDER BY nome";
      else
         query = "SELECT * FROM orcamento ORDER BY nome";
      List<OrcamentoPedido> items = new List<OrcamentoPedido>();
      Tuple<MySqlConnection, MySqlDataReader> select = SelectFromDatabase(query);
      if(select != null){
         if(select.Item2.HasRows)
            while(select.Item2.Read())
               items.Add(GetOrcamentoFromData(select.Item2));
         select.Item2.Close();
         select.Item1.Close();
      }
      return items;
   }

   private OrcamentoPedido GetOrcamento(int id){
      string query = "SELECT * FROM orcamento WHERE id = " + id;
      List<OrcamentoPedido> items = new List<OrcamentoPedido>();
      Tuple<MySqlConnection, MySqlDataReader> select = SelectFromDatabase(query);
      OrcamentoPedido orcamento = null;
      if(select != null){
         if(select.Item2.HasRows){
            select.Item2.Read();
            orcamento = GetOrcamentoFromData(select.Item2);
         }
         select.Item2.Close();
         select.Item1.Close();
      }
      return orcamento;
   }

   private List<BlogItem> GetPageBlog(int page){
      string query = "SELECT * FROM blog ORDER BY id DESC LIMIT " + itensByPage + " OFFSET " + ((page - 1)*itensByPage);
      List<BlogItem> items = new List<BlogItem>();
      Tuple<MySqlConnection, MySqlDataReader> select = SelectFromDatabase(query);
      if(select != null){
         if(select.Item2.HasRows)
            while(select.Item2.Read())
                  items.Add(GetBlogFromData(select.Item2));
         select.Item2.Close();
         select.Item1.Close();
      }
      return items;
   }

   private BlogItem GetBlogItem(int id){
      string query = "SELECT * FROM blog WHERE id = " + id;
      Tuple<MySqlConnection, MySqlDataReader> select = SelectFromDatabase(query);
      BlogItem blogItem = null;
      if(select != null){
         if(select.Item2.HasRows){
            select.Item2.Read();
            blogItem = GetBlogFromData(select.Item2);
         }
         select.Item2.Close();
         select.Item1.Close();
      }
      return blogItem;
   }

   /*INSERTs*/
   private bool NewOrcamento(OrcamentoPedido orcamentoPedido){
      if(ValidateOrcamento(orcamentoPedido)){
         string query = "INSERT INTO orcamento (nome, telefone, email, descricao, ios, android, web) VALUES ('" + orcamentoPedido.nome + "', '" + orcamentoPedido.telefone + "', '" + orcamentoPedido.email + "', '" + orcamentoPedido.descricao + "', " + orcamentoPedido.ios + ", " + orcamentoPedido.android + ", " + orcamentoPedido.web + ");";
         return ExecuteQuery(query);
      }
      return false;
   }

   private bool NewCurriculoItem(ItemCurriculo itemCurriculo){
      if(ValidateCurriculo(itemCurriculo)){
         string query = "INSERT INTO curriculo (titulo, texto) VALUES ('" + itemCurriculo.titulo + "', '" + itemCurriculo.texto + "')";
         return ExecuteQuery(query);
      }
      return false;
   }

   private bool NewProjeto(Projeto projeto){
      if(ValidateProjeto(projeto)){
         string query = "INSERT INTO projetos (nome, descricao, imagem, alternativo, url) VALUES ('" + projeto.nome + "', '" + projeto.descricao + "', '" + projeto.imagem + "', '" + projeto.alternativo + "', '" + projeto.url_project + "')";
         return ExecuteQuery(query);
      }
      return false;
   }

   private bool NewBlogItem(BlogItem b){
      if(ValidateBlog(b)){
         string query = "INSERT INTO blog (title, content) VALUES ('" + b.titulo + "', '" + b.conteudo + "')";
         return ExecuteQuery(query);
      }
      return false;
   }

   /*REMOVEs*/
   private bool RemoveCurriculoItem(int id){
      string query = "DELETE FROM curriculo WHERE id = " + id;
      return ExecuteQuery(query);
   }

   private bool RemoveProjeto(int id){
      string query = "DELETE FROM projetos WHERE id = " + id;
      return ExecuteQuery(query);
   }

   private bool RemoveItemBlog(int id){
      string query = "DELETE FROM blog WHERE id = " + id;
      return ExecuteQuery(query);
   }

   /*UPDATEs*/
   private bool ReadedOrcamento(int id){
      string query = "UPDATE orcamento SET lido = true WHERE id = " + id;
      return ExecuteQuery(query);
   }

   private bool UpdateItemBlog(BlogItem b){
      if(ValidateBlog(b)){
         string query = "UPDATE blog SET title = '" + b.titulo + "', content = '" + b.conteudo + "' WHERE id = " + b.id;
         return ExecuteQuery(query);
      }
      return false;
   }

   /*Confirms*/
   private bool LoginIsEqual(string login, string senha){
      string query = "SELECT * FROM Admins";
      bool res = false;
      Tuple<MySqlConnection, MySqlDataReader> select = SelectFromDatabase(query);
      if(select != null){
         if(select.Item2.HasRows)
            while(select.Item2.Read()){
               if(select.Item2.GetString("login").Equals(login) &&
               select.Item2.GetString("senha").Equals(senha))
                  res = true;
            }
         select.Item2.Close();
         select.Item1.Close();
      }
      return res;
   }

   private bool HasNextPage(int page){
      string query = "select count(*) from blog";
      try{
         MySqlConnection con = new MySqlConnection(enderecoConexao);
         con.Open();
         MySqlCommand comand = new MySqlCommand(query, con);
         double count = (Int64)comand.ExecuteScalar();
         con.Close();
         if((((count / itensByPage) % 1 == 0) ? (count / itensByPage) : ((count / itensByPage) - ((count / itensByPage) % 1))) + ((count % itensByPage == 0) ? 0 : 1) > page)
            return true;
      }catch{}
      return false;
   }

   /*GET PARTS*/
   private Projeto GetProjetoFromData(MySqlDataReader select){
      Projeto projeto = new Projeto();
      if(!select.IsDBNull(select.GetOrdinal("id")))
         projeto.id = select.GetInt16("id");
      if(!select.IsDBNull(select.GetOrdinal("nome")))
         projeto.nome = select.GetString("nome");
      if(!select.IsDBNull(select.GetOrdinal("descricao")))
         projeto.descricao = select.GetString("descricao");
      if(!select.IsDBNull(select.GetOrdinal("imagem")))
         projeto.imagem = select.GetString("imagem");
      if(!select.IsDBNull(select.GetOrdinal("alternativo")))
         projeto.alternativo = select.GetString("alternativo");
      if(!select.IsDBNull(select.GetOrdinal("url")))
         projeto.url_project = select.GetString("url");
      return projeto;
   }

   private ItemCurriculo GetItemCurriculoFromData(MySqlDataReader select){
      ItemCurriculo item = new ItemCurriculo();
         if(!select.IsDBNull(select.GetOrdinal("id")))
            item.id = select.GetInt16("id");
         if(!select.IsDBNull(select.GetOrdinal("titulo")))
            item.titulo = select.GetString("titulo");
         if(!select.IsDBNull(select.GetOrdinal("texto")))
            item.texto = select.GetString("texto");
      return item;   
   }

   private OrcamentoPedido GetOrcamentoFromData(MySqlDataReader select){
      OrcamentoPedido orcamento = new OrcamentoPedido();
      if(!select.IsDBNull(select.GetOrdinal("id")))
            orcamento.id = select.GetInt16("id");
      if(!select.IsDBNull(select.GetOrdinal("lido")))
            orcamento.lido = select.GetBoolean("lido");
      if(!select.IsDBNull(select.GetOrdinal("nome")))
            orcamento.nome = select.GetString("nome");
      if(!select.IsDBNull(select.GetOrdinal("telefone")))
            orcamento.telefone = select.GetString("telefone");
      if(!select.IsDBNull(select.GetOrdinal("email")))
            orcamento.email = select.GetString("email");
      if(!select.IsDBNull(select.GetOrdinal("descricao")))
            orcamento.descricao = select.GetString("descricao");
      if(!select.IsDBNull(select.GetOrdinal("android")))
            orcamento.android = select.GetBoolean("android");
      if(!select.IsDBNull(select.GetOrdinal("ios")))
            orcamento.ios = select.GetBoolean("ios");
      if(!select.IsDBNull(select.GetOrdinal("web")))
            orcamento.web = select.GetBoolean("web");
      return orcamento;
   }

   private BlogItem GetBlogFromData(MySqlDataReader select){
      BlogItem item = new BlogItem();
         if(!select.IsDBNull(select.GetOrdinal("id")))
            item.id = select.GetInt16("id");
         if(!select.IsDBNull(select.GetOrdinal("title")))
            item.titulo = select.GetString("title");
         if(!select.IsDBNull(select.GetOrdinal("content")))
            item.conteudo = select.GetString("content");
      return item; 
   }

   /*Methods*/
   private bool ExecuteQuery(string query){
      try{
         MySqlConnection conexao = new MySqlConnection(enderecoConexao);
         conexao.Open();
         MySqlCommand comando = new MySqlCommand(query, conexao);
         comando.ExecuteNonQuery();
         conexao.Close();
         return true;
      }catch{
         return false;
      }
   }

   private Tuple<MySqlConnection, MySqlDataReader> SelectFromDatabase(string query){
        try{
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();
            MySqlCommand comandoQuery = new MySqlCommand(query, conexao);
            MySqlDataReader resultado = comandoQuery.ExecuteReader();
            return new Tuple<MySqlConnection, MySqlDataReader>(conexao, resultado);
        }catch{
            return null;
        }
   }

   /*VALIDATE*/
   private bool CampCorrect(string s){ return !(s.Contains("'") || s.Contains("SELECT") || s.Contains("REMOVE") || s.Contains("TRUNCATE")  || s.Contains("DROP") || s.Contains("DATABASE") || s.Contains("TABLE") || s.Contains("INSERT") || s.Contains("INTO") || s.Contains("script") || s.Contains("SCRIPT")); }

   private bool ValidateOrcamento(OrcamentoPedido orcamento){
      return (CampCorrect(orcamento.nome) &&
      CampCorrect(orcamento.telefone) &&
      CampCorrect(orcamento.descricao) &&
      CampCorrect(orcamento.email));
   }
   private bool ValidateCurriculo(ItemCurriculo item){
      return (CampCorrect(item.titulo) &&
      CampCorrect(item.texto));
   }

   public bool ValidateProjeto(Projeto projeto){
      return (CampCorrect(projeto.nome) &&
      CampCorrect(projeto.alternativo) &&
      CampCorrect(projeto.imagem) &&
      CampCorrect(projeto.descricao) &&
      CampCorrect(projeto.url_project));
   }

   public bool ValidateBlog(BlogItem b){
      return (CampCorrect(b.titulo) &&
      CampCorrect(b.conteudo));
   }

}