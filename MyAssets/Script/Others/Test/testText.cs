using Godot;
using System;

public class testText : RichTextLabel
{
    private double _timeBegin;
	private double _timeDelay;
    private bool testTextB;

    public bool passed;

    private int sequence, HPnow;

    Sprite icon, aaRosen, NotHexi, Cott, Citt, HPBox, TTW, timeBall, scratchChild;
    Node2D scratchParent, cuppaD, jumpBuild;

    ScratchCat scartchScript;

    hexCatRB hexCatRBcup;

    AnimationPlayer cootAniBox;

    JumpCatRB jcRB;

    public override void _Ready(){

        icon = GetNode<Sprite>("%Icon");
        aaRosen = GetNode<Sprite>("%AaRosen");
        Cott = GetNode<Sprite>("%Cott");
        NotHexi = GetNode<Sprite>("%NotHexi");
        Citt = GetNode<Sprite>("%Citt");
        HPBox = GetNode<Sprite>("%CootHPfull");
        TTW = GetNode<Sprite>("%321");
        timeBall = GetNode<Sprite>("%TimeBall");
        scratchParent = GetNode<Node2D>("%Scratch");
        scratchChild = scratchParent.GetNode<Sprite>("ScratchCat");
        scartchScript = scratchParent.GetNode<ScratchCat>("ScratchCat");
        cootAniBox = HPBox.GetNode<AnimationPlayer>("bbAni");
        cuppaD = GetNode<Node2D>("%CupD");
        hexCatRBcup = GetNode<hexCatRB>("%hexCatRB");
        jumpBuild = GetNode<Node2D>("%JumpTheGap");
        jcRB = GetNode<JumpCatRB>("%JumpCatRB");
    }


    public void _Start(){
        _timeBegin = OS.GetTicksUsec();
    	_timeDelay = AudioServer.GetTimeToNextMix() + AudioServer.GetOutputLatency();
        testTextB = true;
    }
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta){
	    double time = (OS.GetTicksUsec() - _timeBegin) / 1000000.0d;
	    time = Math.Max(0.0d, time - _timeDelay);
	    if (testTextB){
		    GetParent().GetNode<RichTextLabel>("testText").Text = string.Format("Time is: {0}", time);
            if (time >= 0.3d && sequence == 0){
                icon.Show();
                icon.Call("_Start");
                sequence++;
            }else if(time >= 3.9d && sequence == 1){
                aaRosen.Show();
                aaRosen.Call("_Start");
                sequence++;
            }else if(time >= 7.5d && sequence == 2){
                NotHexi.Show();
                NotHexi.Call("_Start");
                sequence++;
            }else if(time >= 10.9d && sequence == 3){
                Cott.Show();
                Cott.Call("_Start");
                sequence++;
            }else if(time >= 12.5d && sequence == 4){
                Citt.Show();
                Citt.Call("_Start");
                sequence++;
            }else if(time >= 17.5d && sequence == 5){
                HPBox.Show();
                HPBox.Call("_Start");
                sequence++;
            }else if(time >= 25.5d && sequence == 6){
                HPBox.Call("_Hide");
                TTW.Show();
                TTW.Call("_Pull"); 
                sequence++;
            }else if(time >= 27.2d && sequence == 7){ //time diff 1.7
                timeBall.Call("_Start");
                timeBall.Show();
                scratchParent.Show();
                scartchScript.letsGo = true;
                sequence++;                
            }else if(time >= 30.6d && sequence == 8){ //time dif 3.4
                if(!passed){
                    HPnow++;
                }
                passed = false;
                
                if(HPnow == 1){
                    cootAniBox.Play("bbAni1");
                }
                scratchParent.QueueFree();
                timeBall.Hide();
                HPBox.Call("_Show");
                sequence++;                
            }else if(time >= 34.0d && sequence == 9){
                HPBox.Call("_Hide");
                TTW.Call("_Swing");
                TTW.Show();
                sequence++; 
            }else if(time >= 35.7d && sequence == 10){
                timeBall.Call("_Start");
                timeBall.Show();
                cuppaD.Show();
                hexCatRBcup.letsGo = true;
                sequence++;
            }else if(time >= 39.1d && sequence == 11){
                if(!passed){
                    HPnow++;
                }
                passed = false;
                
                if(HPnow == 1){
                    cootAniBox.Play("bbAni1");
                }else if(HPnow == 2){
                    cootAniBox.Play("bbAni2");
                }
                cuppaD.QueueFree();
                timeBall.Hide();
                HPBox.Call("_Show");
                sequence++;
            }else if(time >= 42.7d && sequence == 12){
                HPBox.Call("_Hide");
                TTW.Call("_Jump");
                TTW.Show();
                sequence++; 
            }else if(time >= 44.4d && sequence == 13){
                timeBall.Call("_Start");
                timeBall.Show();
                jumpBuild.Show();
                jcRB.letsGo = true;
                sequence++;
            }else if(time >= 47.8d && sequence == 14){
                if(!passed){
                    HPnow++;
                }
                passed = false;
                
                if(HPnow == 1){
                    cootAniBox.Play("bbAni1");
                }else if(HPnow == 2){
                    cootAniBox.Play("bbAni2");
                }else if(HPnow == 3){
                    cootAniBox.Play("bbAni3");
                }
                jumpBuild.QueueFree();
                timeBall.Hide();
                HPBox.Call("_Show");
                sequence++;
            }
        }   
        
}
}
