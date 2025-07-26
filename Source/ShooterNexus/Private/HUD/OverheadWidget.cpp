// Shooter Nexus


#include "HUD/OverheadWidget.h"
#include "Components/TextBlock.h"
#include "GameFramework/PlayerState.h"

void UOverheadWidget::SetDisplayText(FString TextToDisplay)
{
	if (DisplayText)
	{
		DisplayText->SetText(FText::FromString(TextToDisplay));
	}
}

void UOverheadWidget::ShowPlayerNetRole(APawn* InPawn)
{
	if (InPawn == nullptr)
	{
		return;
	}
	APlayerState* PlayerState = InPawn->GetPlayerState();
	if (PlayerState == nullptr)
	{
		return;
	}

	ENetRole NetRole = InPawn->GetRemoteRole();
	FString RoleString;

	switch (NetRole)
	{
	case ENetRole::ROLE_Authority:
		RoleString = FString("Authority");
		break;
	case ENetRole::ROLE_AutonomousProxy:
		RoleString = FString("Autonomous Proxy");
		break;
	case ENetRole::ROLE_SimulatedProxy:
		RoleString = FString("Simulated Proxy");
		break;
	case ENetRole::ROLE_MAX:
		RoleString = FString("MAX");
		break;
	case ENetRole::ROLE_None:
		RoleString = FString("None");
		break;
	}
	FString PlayerName = PlayerState->GetPlayerName();
	FString FinalString = FString::Printf(TEXT("Player: %s | Remote Role: %s"), *PlayerName, *RoleString);
	SetDisplayText(FinalString);
}

void UOverheadWidget::NativeDestruct()
{
	RemoveFromParent();

	Super::NativeDestruct();
}
