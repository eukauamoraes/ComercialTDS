WebService CEPExemplosCódigosContribuir
foi bom para você?
Faça um doação para o FAP
(fundo de amparo ao programador, que sou eu)
PayPal - The safer, easier way to pay online! 


buscar cep
CEP: 
 


Nesta página você encontra exemplo de código para busca de endereços através do CEP através do nosso WebService nas seguintes linguages:
Adobe Air
ASP
C++
Cobol
Delphi 7
Flash
Java
.NET C#
.NET VB
Perl
PHP
Python
Ruby

Busca de CEP em PHP
Busca de CEP em ASP
Busca de CEP em Flash
Busca de CEP em Adobe Air
Busca de CEP em .NET C#
Download exemplo ASP.NET com C# utilizando AJAX, Framework 3.5 por Gustavo Henrique (71 kb)


Abaixo, exemplo enviado por Valter Henrique Junior utilizando XML
view plainprint?
//Criado por: Valter Henrique Junior  
using System;  
using System.Collections.Generic;  
using System.Text;  
using System.Data;  
namespace NcMaster
{
    public class WebCEP
    {
        #region "Váriavies"  
        string _uf;
        string _cidade;
        string _bairro;
        string _tipo_lagradouro;
        string _lagradouro;
        string _resultado;
        string _resultato_txt;
        #endregion

        #region "Propiedades"  
        public string UF
        {
            get { return _uf; }
        }
        public string Cidade
        {
            get { return _cidade; }
        }
        public string Bairro
        {
            get { return _bairro; }
        }
        public string TipoLagradouro
        {
            get { return _tipo_lagradouro; }
        }
        public string Lagradouro
        {
            get { return _lagradouro; }
        }
        public string Resultado
        {
            get { return _resultado; }
        }
        public string ResultadoTXT
        {
            get { return _resultato_txt; }
        }
        #endregion
        #region "Construtor"  
        /// <summary>  
        /// WebService para Busca de CEP  
        ///  </summary>  
        /// <param  name="CEP"></param>  
        public WebCEP(string CEP)
        {
            _uf = "";
            _cidade = "";
            _bairro = "";
            _tipo_lagradouro = "";
            _lagradouro = "";
            _resultado = "0";
            _resultato_txt = "CEP não encontrado";

            //Cria um DataSet  baseado no retorno do XML  
            DataSet ds = new DataSet();
            ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + CEP.Replace("-", "").Trim() + "&formato=xml");

            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    _resultado = ds.Tables[0].Rows[0]["resultado"].ToString();
                    switch (_resultado)
                    {
                        case "1":
                            _uf = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                            _cidade = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
                            _bairro = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                            _tipo_lagradouro = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString().Trim();
                            _lagradouro = ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                            _resultato_txt = "CEP completo";
                            break;
                        case "2":
                            _uf = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                            _cidade = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
                            _bairro = "";
                            _tipo_lagradouro = "";
                            _lagradouro = "";
                            _resultato_txt = "CEP  único";
                            break;
                        default:
                            _uf = "";
                            _cidade = "";
                            _bairro = "";
                            _tipo_lagradouro = "";
                            _lagradouro = "";
                            _resultato_txt = "CEP não  encontrado";
                            break;
                    }
                }
            }
            //Exemplo do retorno da  WEB  
            //<?xml version="1.0"  encoding="iso-8859-1"?>  
            //<webservicecep>  
            //<uf>RS</uf>  
            //<cidade>Porto  Alegre</cidade>  
            //<bairro>Passo  D'Areia</bairro>  
            //<tipo_logradouro>Avenida</tipo_logradouro>  
            //<logradouro>Assis Brasil</logradouro>  
            //<resultado>1</resultado>  
            //<resultado_txt>sucesso - cep  completo</resultado_txt>  
            //</webservicecep>  
        }
        #endregion
    }
}
Busca de CEP em .NET VB
Busca de CEP em Python
Busca de CEP em Ruby
Busca de CEP em Perl
Busca de CEP em Java
Busca de CEP em C++
Busca de CEP em Delphi 7
Busca de CEP em Cobol

Quer ajuda um pouco?
E ai cara, sua linguagem de programação não está aqui?
Mande para nossa equipe colocar aqui e ajude outros programadores que nem você!!! Larga dessa de só sugar na internet e ajuda um pouco!

Contribua com o site, envie seu código

website monitoring service

RIO GRANDE DO SUL BRASIL
bombando desde 12/2005 - 193.538.729 requisições até o momento

