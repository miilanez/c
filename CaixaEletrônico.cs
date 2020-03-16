using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("QUANTIDADE QUE DESEJA RETIRAR: ");
                int VALOR = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(VALOR % 1000);
                Console.WriteLine("Quantidades de notas de 100: " + VALOR / 100);
                VALOR = VALOR - (VALOR / 100 * 100);
                Console.WriteLine("Quantidades de notas de 50: " + (VALOR / 50));
                VALOR = VALOR - (VALOR / 50 * 50);
                Console.WriteLine("Quantidades de notas de 20: " + (VALOR / 20));
                VALOR = VALOR - ((VALOR / 20) * 20);
                Console.WriteLine("Quantidades de notas de 10: " + (VALOR / 10));
                VALOR = VALOR - ((VALOR / 10) * 10);
                Console.WriteLine("Quantidades de notas de 5: " + (VALOR / 5));
                VALOR = VALOR - ((VALOR / 5) * 5);
                Console.WriteLine("Quantidades de notas de 2: " + (VALOR / 2));
                VALOR = VALOR - ((VALOR / 2) * 2);
                Console.WriteLine("Quantidades notas de 1: " + (VALOR));

                Console.ReadLine();

            }
        }
    }
}

# by: Mr. Thanathos
# --------------------------------

#                     ...----....
#                    ..-:"''         ''"-..
#                 .-'                      '-.
#               .'              .     .       '.
#             .'   .          .    .      .    .''.
#           .'  .    .       .   .   .     .   . ..:.
#         .' .   . .  .       .   .   ..  .   . ....::.
#        ..   .   .      .  .    .     .  ..  . ....:IA.
#       .:  .   .    .    .  .  .    .. .  .. .. ....:IA.
#      .: .   .   ..   .    .     . . .. . ... ....:.:VHA.
#      '..  .  .. .   .       .  . .. . .. . .....:.::IHHB.
#     .:. .  . .  . .   .  .  . . . ...:.:... .......:HIHMM.
#    .:.... .   . ."::"'.. .   .  . .:.:.:II;,. .. ..:IHIMMA
#    ':.:..  ..::IHHHHHI::. . .  ...:.::::.,,,. . ....VIMMHM
#   .:::I. .AHHHHHHHHHHAI::. .:...,:IIHHHHHHMMMHHL:. . VMMMM
#  .:.:V.:IVHHHHHHHMHMHHH::..:" .:HIHHHHHHHHHHHHHMHHA. .VMMM.
#  :..V.:IVHHHHHMMHHHHHHHB... . .:VPHHMHHHMMHHHHHHHHHAI.:VMMI
#  ::V..:VIHHHHHHMMMHHHHHH. .   .I":IIMHHMMHHHHHHHHHHHAPI:WMM
#  ::". .:.HHHHHHHHMMHHHHHI.  . .:..I:MHMMHHHHHHHHHMHV:':H:WM
#  :: . :.::IIHHHHHHMMHHHHV  .ABA.:.:IMHMHMMMHMHHHHV:'. .IHWW
#  '.  ..:..:.:IHHHHHMMHV" .AVMHMA.:.'VHMMMMHHHHHV:' .  :IHWV
#   :.  .:...:".:.:TPP"   .AVMMHMMA.:. "VMMHHHP.:... .. :IVAI
#  .:.   '... .:"'   .   ..HMMMHMMMA::. ."VHHI:::....  .:IHW'
#  ...  .  . ..:IIPPIH: ..HMMMI.MMMV:I:.  .:ILLH:.. ...:I:IM
#: .   .'"' .:.V". .. .  :HMMM:IMMMI::I. ..:HHIIPPHI::'.P:HM.
#:.  .  .  .. ..:.. .    :AMMM IMMMM..:...:IV":T::I::.".:IHIMA
#'V:.. .. . .. .  .  .   'VMMV..VMMV :....:V:.:..:....::IHHHMH
#  "IHH:.II:.. .:. .  . . . " :HB"" . . ..PI:.::.:::..:IHHMMV"
#   :IP""HHII:.  .  .    . . .'V:. . . ..:IH:.:.::IHIHHMMMMM"
#   :V:. VIMA:I..  .     .  . .. . .  .:.I:I:..:IHHHHMMHHMMM
#   :"VI:.VWMA::. .:      .   .. .:. ..:.I::.:IVHHHMMMHMMMMI
#   :."VIIHHMMA:.  .   .   .:  .:.. . .:.II:I:AMMMMMMHMMMMMI
#   :..VIHIHMMMI...::.,:.,:!"I:!"I!"I!"V:AI:VAMMMMMMHMMMMMM'
#   ':.:HIHIMHHA:"!!"I.:AXXXVVXXXXXXXA:."HPHIMMMMHHMHMMMMMV
#     V:H:I:MA:W'I :AXXXIXII:IIIISSSSSSXXA.I.VMMMHMHMMMMMM
#       'I::IVA ASSSSXSSSSBBSBMBSSSSSSBBMMMBS.VVMMHIMM'"'
#        I:: VPAIMSSSSSSSSSBSSSMMBSSSBBMMMMXXI:MMHIMMI
#       .I::. "H:XIIXBBMMMMMMMMMMMMMMMMMBXIXXMMPHIIMM'
#       :::I.  ':XSSXXIIIIXSSBMBSSXXXIIIXXSMMAMI:.IMM
#       :::I:.  .VSSSSSISISISSSBII:ISSSSBMMB:MI:..:MM
#       ::.I:.  ':"SSSSSSSISISSXIIXSSSSBMMB:AHI:..MMM.
#       ::.I:. . ..:"BBSSSSSSSSSSSSBBBMMMB:AHHI::.HMMI
#       :..::.  . ..::":BBBBBSSBBBMMMB:MMMMHHII::IHHMI
#       ':.I:... ....:IHHHHHMMMMMMMMMMMMMMMHHIIIIHMMV"
#         "V:. ..:...:.IHHHMMMMMMMMMMMMMMMMHHHMHHMHP'
#          ':. .:::.:.::III::IHHHHMMMMMHMHMMHHHHM"
#            "::....::.:::..:..::IIIIIHHHHMMMHHMV"
#              "::.::.. .. .  ...:::IIHHMMMMHMV"
#                "V::... . .I::IHHMMV"'
#                  '"VHVHHHAHHHHMMV:"'
