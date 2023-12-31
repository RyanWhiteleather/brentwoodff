import {
  ListItem,
  ListItemButton,
  ListItemIcon,
  ListItemText,
} from "@mui/material";
import HomeIcon from "@mui/icons-material/Home";
import FormatListNumberedIcon from "@mui/icons-material/FormatListNumbered";
import GroupsIcon from "@mui/icons-material/Groups";
import EmojiEventsIcon from "@mui/icons-material/EmojiEvents";
import AssignmentIndIcon from "@mui/icons-material/AssignmentInd";
import FolderIcon from "@mui/icons-material/Folder";
import HistoryEduIcon from "@mui/icons-material/HistoryEdu";

const linkData = [
  { link: "/", label: "Home", icon: HomeIcon },
  { link: "/standings", label: "Standings", icon: FormatListNumberedIcon },
  { link: "/teams", label: "Teams", icon: GroupsIcon },
  { link: "/champions", label: "Champions", icon: EmojiEventsIcon },
  { link: "/draft", label: "The Draft", icon: AssignmentIndIcon },
  { link: "/records", label: "Records", icon: FolderIcon },
  { link: "/constitution", label: "Constitution", icon: HistoryEduIcon },
];

interface SideNavLinksProps {
  open: boolean;
}

export function SideNavLinks({ open }: SideNavLinksProps) {
  const links = linkData.map((item) => (
    <ListItem key={item.label} disablePadding sx={{ display: "block" }}>
      <ListItemButton
        sx={{
          minHeight: 48,
          justifyContent: { open } ? "initial" : "center",
          px: 2.5,
        }}
      >
        <ListItemIcon
          sx={{
            minWidth: 0,
            mr: { open } ? 3 : "auto",
            justifyContent: "center",
          }}
        >
          {<item.icon />}
        </ListItemIcon>
        <ListItemText primary={item.label} sx={{ opacity: { open } ? 1 : 0 }} />
      </ListItemButton>
    </ListItem>
  ));

  return <>{links}</>;
}

{
  /* <ListItem key=
{[
  "Standings",
  "Champions",
  "The Draft",
  "Records",
  "Teams",
  "Constitution",
].map((text, index) => (
  <ListItem key={text} disablePadding sx={{ display: "block" }}>
    <ListItemButton
      sx={{
        minHeight: 48,
        justifyContent: open ? "initial" : "center",
        px: 2.5,
      }}
    >
      <ListItemIcon
        sx={{
          minWidth: 0,
          mr: open ? 3 : "auto",
          justifyContent: "center",
        }}
      >
        {index % 2 === 0 ? <InboxIcon /> : <MailIcon />}
      </ListItemIcon>
      <ListItemText primary={text} sx={{ opacity: open ? 1 : 0 }} />
    </ListItemButton>
  </ListItem>
))} */
}
