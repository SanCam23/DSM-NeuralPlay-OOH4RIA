

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class PerfilCEN
 *
 */
public partial class PerfilCEN
{
private IPerfilRepository _IPerfilRepository;

public PerfilCEN(IPerfilRepository _IPerfilRepository)
{
        this._IPerfilRepository = _IPerfilRepository;
}

public IPerfilRepository get_IPerfilRepository ()
{
        return this._IPerfilRepository;
}

public int New_ (string p_fotoPerfilUrl, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum p_visibilidadPerfil, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum p_visibilidadActividad, string p_descripcion, string p_juegoFavorito)
{
        PerfilEN perfilEN = null;
        int oid;

        //Initialized PerfilEN
        perfilEN = new PerfilEN ();
        perfilEN.FotoPerfilUrl = p_fotoPerfilUrl;

        perfilEN.VisibilidadPerfil = p_visibilidadPerfil;

        perfilEN.VisibilidadActividad = p_visibilidadActividad;

        perfilEN.Descripcion = p_descripcion;

        perfilEN.JuegoFavorito = p_juegoFavorito;



        oid = _IPerfilRepository.New_ (perfilEN);
        return oid;
}

public void Modify (int p_Perfil_OID, string p_fotoPerfilUrl, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum p_visibilidadPerfil, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum p_visibilidadActividad, string p_descripcion, string p_juegoFavorito)
{
        PerfilEN perfilEN = null;

        //Initialized PerfilEN
        perfilEN = new PerfilEN ();
        perfilEN.Id = p_Perfil_OID;
        perfilEN.FotoPerfilUrl = p_fotoPerfilUrl;
        perfilEN.VisibilidadPerfil = p_visibilidadPerfil;
        perfilEN.VisibilidadActividad = p_visibilidadActividad;
        perfilEN.Descripcion = p_descripcion;
        perfilEN.JuegoFavorito = p_juegoFavorito;
        //Call to PerfilRepository

        _IPerfilRepository.Modify (perfilEN);
}

public void Destroy (int id
                     )
{
        _IPerfilRepository.Destroy (id);
}

public PerfilEN ReadOID (int id
                         )
{
        PerfilEN perfilEN = null;

        perfilEN = _IPerfilRepository.ReadOID (id);
        return perfilEN;
}

public System.Collections.Generic.IList<PerfilEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PerfilEN> list = null;

        list = _IPerfilRepository.ReadAll (first, size);
        return list;
}
}
}
