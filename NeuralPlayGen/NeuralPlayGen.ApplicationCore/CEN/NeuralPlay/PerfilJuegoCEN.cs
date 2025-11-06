

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class PerfilJuegoCEN
 *
 */
public partial class PerfilJuegoCEN
{
private IPerfilJuegoRepository _IPerfilJuegoRepository;

public PerfilJuegoCEN(IPerfilJuegoRepository _IPerfilJuegoRepository)
{
        this._IPerfilJuegoRepository = _IPerfilJuegoRepository;
}

public IPerfilJuegoRepository get_IPerfilJuegoRepository ()
{
        return this._IPerfilJuegoRepository;
}

public int New_ (Nullable<DateTime> p_fechaAccion, int p_perfil, int p_juego)
{
        PerfilJuegoEN perfilJuegoEN = null;
        int oid;

        //Initialized PerfilJuegoEN
        perfilJuegoEN = new PerfilJuegoEN ();
        perfilJuegoEN.FechaAccion = p_fechaAccion;


        if (p_perfil != -1) {
                // El argumento p_perfil -> Property perfil es oid = false
                // Lista de oids id
                perfilJuegoEN.Perfil = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN ();
                perfilJuegoEN.Perfil.Id = p_perfil;
        }


        if (p_juego != -1) {
                // El argumento p_juego -> Property juego es oid = false
                // Lista de oids id
                perfilJuegoEN.Juego = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN ();
                perfilJuegoEN.Juego.Id = p_juego;
        }



        oid = _IPerfilJuegoRepository.New_ (perfilJuegoEN);
        return oid;
}

public void Modify (int p_PerfilJuego_OID, Nullable<DateTime> p_fechaAccion)
{
        PerfilJuegoEN perfilJuegoEN = null;

        //Initialized PerfilJuegoEN
        perfilJuegoEN = new PerfilJuegoEN ();
        perfilJuegoEN.Id = p_PerfilJuego_OID;
        perfilJuegoEN.FechaAccion = p_fechaAccion;
        //Call to PerfilJuegoRepository

        _IPerfilJuegoRepository.Modify (perfilJuegoEN);
}

public void Destroy (int id
                     )
{
        _IPerfilJuegoRepository.Destroy (id);
}

public PerfilJuegoEN ReadOID (int id
                              )
{
        PerfilJuegoEN perfilJuegoEN = null;

        perfilJuegoEN = _IPerfilJuegoRepository.ReadOID (id);
        return perfilJuegoEN;
}

public System.Collections.Generic.IList<PerfilJuegoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PerfilJuegoEN> list = null;

        list = _IPerfilJuegoRepository.ReadAll (first, size);
        return list;
}
}
}
