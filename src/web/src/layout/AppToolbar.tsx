import { Toolbar, IconButton, Typography } from "@mui/material";
import MenuIcon from "@mui/icons-material/Menu";

interface AppToolbarProps {
  open: boolean;
  setOpen: React.Dispatch<React.SetStateAction<boolean>>;
}

export function AppToolbar({ open, setOpen }: AppToolbarProps) {
  const handleDrawerOpen = () => {
    setOpen(true);
  };
  return (
    <Toolbar>
      <IconButton
        color="inherit"
        aria-label="open drawer"
        onClick={handleDrawerOpen}
        edge="start"
        sx={{
          marginRight: 5,
          ...({ open } && { display: "none" }),
        }}
      >
        <MenuIcon />
      </IconButton>
      <Typography variant="h6" noWrap component="div">
        Brentwood Brodown
      </Typography>
    </Toolbar>
  );
}
