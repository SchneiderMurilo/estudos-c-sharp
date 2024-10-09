using minimal_api.Migrations;
using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Dominio.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);

    Administrador? Incluir(Administrador administrador);

    List<Administrador> Todos(int? pagina);
}