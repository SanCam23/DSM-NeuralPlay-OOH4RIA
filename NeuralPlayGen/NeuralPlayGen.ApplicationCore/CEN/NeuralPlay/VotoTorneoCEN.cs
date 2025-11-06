

using System;
using System.Text;
using System.Collections.Generic;

using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
/*
 *      Definition of the class VotoTorneoCEN
 *
 */
public partial class VotoTorneoCEN
{
private IVotoTorneoRepository _IVotoTorneoRepository;

public VotoTorneoCEN(IVotoTorneoRepository _IVotoTorneoRepository)
{
        this._IVotoTorneoRepository = _IVotoTorneoRepository;
}

public IVotoTorneoRepository get_IVotoTorneoRepository ()
{
        return this._IVotoTorneoRepository;
}

public int New_ (bool p_valor, Nullable<DateTime> p_fechaVoto, int p_propuestaTorneo, int p_usuario)
{
        VotoTorneoEN votoTorneoEN = null;
        int oid;

        //Initialized VotoTorneoEN
        votoTorneoEN = new VotoTorneoEN ();
        votoTorneoEN.Valor = p_valor;

        votoTorneoEN.FechaVoto = p_fechaVoto;


        if (p_propuestaTorneo != -1) {
                // El argumento p_propuestaTorneo -> Property propuestaTorneo es oid = false
                // Lista de oids id
                votoTorneoEN.PropuestaTorneo = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN ();
                votoTorneoEN.PropuestaTorneo.Id = p_propuestaTorneo;
        }


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                votoTorneoEN.Usuario = new NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN ();
                votoTorneoEN.Usuario.Id = p_usuario;
        }



        oid = _IVotoTorneoRepository.New_ (votoTorneoEN);
        return oid;
}

public void Modify (int p_VotoTorneo_OID, bool p_valor, Nullable<DateTime> p_fechaVoto)
{
        VotoTorneoEN votoTorneoEN = null;

        //Initialized VotoTorneoEN
        votoTorneoEN = new VotoTorneoEN ();
        votoTorneoEN.Id = p_VotoTorneo_OID;
        votoTorneoEN.Valor = p_valor;
        votoTorneoEN.FechaVoto = p_fechaVoto;
        //Call to VotoTorneoRepository

        _IVotoTorneoRepository.Modify (votoTorneoEN);
}

public void Destroy (int id
                     )
{
        _IVotoTorneoRepository.Destroy (id);
}

public VotoTorneoEN ReadOID (int id
                             )
{
        VotoTorneoEN votoTorneoEN = null;

        votoTorneoEN = _IVotoTorneoRepository.ReadOID (id);
        return votoTorneoEN;
}

public System.Collections.Generic.IList<VotoTorneoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<VotoTorneoEN> list = null;

        list = _IVotoTorneoRepository.ReadAll (first, size);
        return list;
}
}
}
