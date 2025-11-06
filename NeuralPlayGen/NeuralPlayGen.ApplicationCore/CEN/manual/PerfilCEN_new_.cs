
using System;
using System.Text;
using System.Collections.Generic;
using NeuralPlayGen.ApplicationCore.Exceptions;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


/*PROTECTED REGION ID(usingNeuralPlayGen.ApplicationCore.CEN.NeuralPlay_Perfil_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
public partial class PerfilCEN
{
public int New_ (string p_fotoPerfilUrl, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum p_visibilidadPerfil, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum p_visibilidadActividad, string p_descripcion, string p_juegoFavorito)
{
        /*PROTECTED REGION ID(NeuralPlayGen.ApplicationCore.CEN.NeuralPlay_Perfil_new__customized) ENABLED START*/

        // --- INICIO VALIDACI�N PRIVACIDAD ---
        // Si la visibilidad del perfil NO es p�blica, la actividad NO puede ser p�blica.
        if (p_visibilidadPerfil != NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum.Publico
            && p_visibilidadActividad == NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.VisibilidadEnum.Publico) {
                throw new Exception ("Incoherencia de privacidad: No puedes tener la actividad p�blica si tu perfil no lo es.");
        }
        // --- FIN VALIDACI�N PRIVACIDAD ---

        PerfilEN perfilEN = null;

        int oid;

        //Initialized PerfilEN
        perfilEN = new PerfilEN ();
        perfilEN.FotoPerfilUrl = p_fotoPerfilUrl;

        perfilEN.VisibilidadPerfil = p_visibilidadPerfil;

        perfilEN.VisibilidadActividad = p_visibilidadActividad;

        perfilEN.Descripcion = p_descripcion;

        perfilEN.JuegoFavorito = p_juegoFavorito;

        //Call to PerfilRepository

        oid = _IPerfilRepository.New_ (perfilEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
