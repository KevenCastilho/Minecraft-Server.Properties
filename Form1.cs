using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Minecraft_Server_Properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Criei a Stream para manipular o arquivo
                StreamWriter server_properties = new StreamWriter("server.properties", true, Encoding.ASCII);
                // Escrevi comentario
                server_properties.WriteLine("#Minecraft server properties");
                // Escrevi comentario
                server_properties.WriteLine("#Gerado por Minecraft Server.Properties");
                // Escrevi Linha IP do Servidor
                server_properties.WriteLine("server-ip=" + txtIPdoServer.Text);
                // Escrevi Linha Porta do Servidor
                server_properties.WriteLine("server-port=" + numPortaDoServer.Value);

                // Escreve a Linha Online Mode
                switch (cbModo.SelectedItem.ToString())
                {
                    case "Original":
                        server_properties.WriteLine("online-mode=true");
                        break;

                    case "Pirata":
                        server_properties.WriteLine("online-mode=false");
                        break;

                    default:
                        server_properties.WriteLine("online-mode=true");
                        break;
                }

                // Escrevi Linha Slots
                server_properties.WriteLine("max-players=" + numSlots.Value);
                // Escrevi Linha Motd
                server_properties.WriteLine("motd =" + txtMotd.Text);

                // Escreve a Linha Modo de Jogo
                switch (cbModoDeJogo.SelectedItem.ToString())
                {
                    case "Sobrevivencia":
                        server_properties.WriteLine("gamemode=survival");
                        break;

                    case "Criativo":
                        server_properties.WriteLine("gamemode=creative");
                        break;

                    case "Aventura":
                        server_properties.WriteLine("gamemode=adventure");
                        break;

                    case "Espectador":
                        server_properties.WriteLine("gamemode=spectator");
                        break;

                    default:
                        server_properties.WriteLine("gamemode=survival");
                        break;
                }

                // Escreve a Linha Forçar mogo de jogo
                if (cboxModoDeJogo.Checked)
                {
                    server_properties.WriteLine("force-gamemode=true");
                }
                else
                {
                    server_properties.WriteLine("force-gamemode=false");
                }

                // Escreve a Linha Dificuldade
                switch (cbDificuldade.SelectedItem.ToString())
                {
                    case "Pacifico":
                        server_properties.WriteLine("difficulty=peaceful");
                        break;

                    case "Facil":
                        server_properties.WriteLine("difficulty=easy");
                        break;

                    case "Normal":
                        server_properties.WriteLine("difficulty=normal");
                        break;

                    case "Dificil":
                        server_properties.WriteLine("difficulty=hard");
                        break;

                    default:
                        server_properties.WriteLine("difficulty=easy");
                        break;
                }

                // Escreve a Linha hardcore
                if (cboxHardcore.Checked)
                {
                    server_properties.WriteLine("hardcore=true");
                }
                else
                {
                    server_properties.WriteLine("hardcore=false");
                }

                // Escreve a Linha PVP
                switch (cbPVP.SelectedItem.ToString())
                {
                    case "Ativado":
                        server_properties.WriteLine("pvp=true");
                        break;

                    case "Desativado":
                        server_properties.WriteLine("pvp=false");
                        break;

                    default:
                        server_properties.WriteLine("pvp=true");
                        break;
                }

                // Escreve a Linha Nome do Mundo
                server_properties.WriteLine("level-name=" + txtNomeDoMundo.Text);

                // Escreve a Linha Tipo de Mundo
                switch (cbTipoDoMundo.SelectedItem.ToString())
                {
                    case "Padrão":
                        server_properties.WriteLine("level-type=default");
                        break;

                    case "Plano":
                        server_properties.WriteLine("level-type=flat");
                        break;

                    case "Biomas Largos":
                        server_properties.WriteLine("level-type=largeBiomes");
                        break;

                    case "Amplificado":
                        server_properties.WriteLine("level-type=amplified");
                        break;

                    default:
                        server_properties.WriteLine("level-type=default");
                        break;
                }

                // Escreve a Linha Seed
                server_properties.WriteLine("level-seed=" + txtSeed.Text);

                // Escreve a Linha Altura Maxima do Mundo
                server_properties.WriteLine("max-build-height==" + numAlturaMaxima.Value);

                // Escreve a Linha Nether
                if (cboxNether.Checked)
                {
                    server_properties.WriteLine("allow-nether=true");
                }
                else
                {
                    server_properties.WriteLine("allow-nether=false");
                }

                // Escreve a Linha Gerar Construções
                if (cboxConstruções.Checked)
                {
                    server_properties.WriteLine("generate-structures=true");
                }
                else
                {
                    server_properties.WriteLine("generate-structures=false");
                }

                // Escreve a Linha Gerar Animais
                if (cboxAnimais.Checked)
                {
                    server_properties.WriteLine("spawn-animals=true");
                }
                else
                {
                    server_properties.WriteLine("spawn-animals=false");
                }

                // Escreve a Linha Gerar Monstros
                if (cboxMonstros.Checked)
                {
                    server_properties.WriteLine("spawn-monsters=true");
                }
                else
                {
                    server_properties.WriteLine("spawn-monsters=false");
                }

                // Escreve a Linha Gerar NPC's
                if (cboxNPCs.Checked)
                {
                    server_properties.WriteLine("spawn-npcs=true");
                }
                else
                {
                    server_properties.WriteLine("spawn-npcs=false");
                }

                // Escreve a Linha permitir bloco de comando
                if (cboxCommandBlock.Checked)
                {
                    server_properties.WriteLine("enable-command-block=true");
                }
                else
                {
                    server_properties.WriteLine("enable-command-block=false");
                }

                // Escreve a Linha Whitelist
                if (cboxWhitelist.Checked)
                {
                    server_properties.WriteLine("white-list=true");
                }
                else
                {
                    server_properties.WriteLine("white-list=false");
                }

                // Escreve a Linha Forçar Whitelist
                if (cboxForceWhitelist.Checked)
                {
                    server_properties.WriteLine("enforce-whitelist=true");
                }
                else
                {
                    server_properties.WriteLine("enforce-whitelist=false");
                }

                // Escreve a Linha Permitir Voar
                if (cboxAllowFly.Checked)
                {
                    server_properties.WriteLine("allow-flight=true");
                }
                else
                {
                    server_properties.WriteLine("allow-flight=false");
                }

                // Escreve a Linha Distancia de renderização
                server_properties.WriteLine("view-distance=" + numRenderização.Value);

                // Escreve a Linha Proteção do Spawn
                server_properties.WriteLine("spawn-protection=" + numSpawnProtect.Value);

                // Escreve a Linha Permitir Espiar
                if (cboxEspiar.Checked)
                {
                    server_properties.WriteLine("snooper-enabled=true");
                }
                else
                {
                    server_properties.WriteLine("snooper-enabled=false");
                }

                // Escreve a Linha Maximo de Ticks
                server_properties.WriteLine("max-tick-time=" + numTicks.Value);

                // Escreve a Linha Definições de Geração
                server_properties.WriteLine("generator-settings=" + txtGeração.Text);

                // Escreve a Linha Tamanho maximo do mundo
                server_properties.WriteLine("max-world-size=" + numTamanhoMaximoMundo.Value);

                // Escreve a Linha Tempo maximo AFK
                server_properties.WriteLine("player-idle-timeout=" + numAFK.Value);

                // Escreve a Linha Resource Pack
                server_properties.WriteLine("resource-pack=" + txtResourcePack.Text);

                // Escreve a Linha Resource Pack sha1
                server_properties.WriteLine("resource-pack=" + txtResourcePacksha1.Text);

                // Escreve a Linha Anunciar novo OP no console
                if (cboxAnunciarOPconsole.Checked)
                {
                    server_properties.WriteLine("broadcast-console-to-ops=true");
                }
                else
                {
                    server_properties.WriteLine("broadcast-console-to-ops=false");
                }

                // Escreve a Linha Habilitar suporte para query
                if (cboxQuery.Checked)
                {
                    server_properties.WriteLine("enable-query=true");
                }
                else
                {
                    server_properties.WriteLine("enable-query=false");
                }

                // Escreve a Linha Porta query
                server_properties.WriteLine("query.port=" + numPortaQuery.Value);

                // Escreve a Linha Habilitar sistema rcon
                if (cboxRcon.Checked)
                {
                    server_properties.WriteLine("enable-rcon=true");
                }
                else
                {
                    server_properties.WriteLine("enable-rcon=false");
                }

                // Escreve a Linha Porta rcon
                server_properties.WriteLine("rcon.port=" + numRconPort.Value);

                // Escreve a Linha Senha rcon
                server_properties.WriteLine("rcon.password=" + txtSenharcon.Text);

                // Escreve a Linha Anunciar novo OP no rcon
                if (cboxAnunciarOPrcon.Checked)
                {
                    server_properties.WriteLine("broadcast-rcon-to-ops=true");
                }
                else
                {
                    server_properties.WriteLine("broadcast-rcon-to-ops=false");
                }

                // Escreve a Linha Level de permissão OP
                server_properties.WriteLine("op-permission-level=" + numLVLPermOP.Value);

                // Escreve a Linha Level de permissão para usar function
                server_properties.WriteLine("function-permission-level=" + numLVLPermFunction.Value);

                // Escreve a Linha Limite de compressão de rede
                server_properties.WriteLine("network-compression-threshold=" + numLimiteCompressãoRede.Value);

                // Escreve a Linha Rejeitar conexões via proxy
                if (cboxRejeitarConexõesProxy.Checked)
                {
                    server_properties.WriteLine("prevent-proxy-connections=true");
                }
                else
                {
                    server_properties.WriteLine("prevent-proxy-connections=false");
                }

                // Escreve a Linha Usar native transport
                if (cboxNativeTransport.Checked)
                {
                    server_properties.WriteLine("use-native-transport=true");
                }
                else
                {
                    server_properties.WriteLine("use-native-transport=false");
                }

                server_properties.Close();
            } catch (Exception erro)
            {
                MessageBox.Show("Exception: " + erro.Message,"Erro!", MessageBoxButtons.OK);
            }
            finally
            {
                MessageBox.Show("Arquivo criado com sucesso!", "Mensagem", MessageBoxButtons.OK);
            }

        }
    }
}
